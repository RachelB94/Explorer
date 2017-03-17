using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Util;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;


namespace Puzzles
{
    public class PuzzlePage : ContentPage
    {





        // Number of squares horizontally and vertically,
        //  but if you change it, some code will break.
        static readonly int NUM = 4;




        // Array of XuzzleSquare views, and empty row & column.
        PuzzleSquare[,] squares = new PuzzleSquare[NUM, NUM];
        //Bitmap[,] bmp;




        int emptyRow = NUM - 1;
        int emptyCol = NUM - 1;

        StackLayout stackLayout;
        Xamarin.Forms.AbsoluteLayout absoluteLayout;
        Xamarin.Forms.Button randomizeButton;
        Label timeLabel;
        double squareSize;
        bool isBusy;
        bool isPlaying;
        double tileSize;
        private int images;

        public PuzzlePage()
        {
            // AbsoluteLayout to host the squares.
            absoluteLayout = new Xamarin.Forms.AbsoluteLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };


            // Create XuzzleSquare's for all the rows and columns.


            Image[] normalImages = new Image[NUM * NUM];


            int index = 0;



            for (int row = 0; row < NUM; row++)
            {
                for (int col = 0; col < NUM; col++)
                {
                    // But skip the last one! 
                    if (row == NUM - 1 && col == NUM - 1)
                        break;



                    // Instantiate the image reading it from the local resources. 
                    normalImages[index] = new Image();
                    normalImages[index].Source = ImageSource
                    .FromResource(String.Format("Puzzles.ImagesMedium.insect" + index  + ".png"));

                    //Bitmap bmp = BitmapFactory.DecodeResourceAsync(String.Format("Puzzles.test.png"));
                    //BitmapDrawable bitmapDrawable = new BitmapDrawable(bmp);
                    //bitmapDrawable.SetTileModeXY(Shader.TileMode.Repeat, Shader.TileMode.Repeat);






                    //getPuzzleBitmap(image);

                    //ImageView imageview = (ImageView)("Puzzles.test.png");

                    //Bitmap drawingCache = imageview.GetDrawingCache(true);
                    //Canvas canvas = new Canvas();
                    //Rect src = new Rect(23, 12, 23, 12);
                    //RectF dst = new RectF(0, 20, 0, 20); Paint paint = new Paint();
                    //canvas.DrawBitmap(drawingCache, src, dst, paint);



                    //Bitmap piece = Bitmap.CreateBitmap(normalImages, row, col, 30, 30);





                    //Drawable myDrawable = getResources().getDrawable(R.drawable.logo);
                    //Bitmap myLogo = ((BitmapDrawable)myDrawable).getBitmap();





                    // Instantiate XuzzleSquare.
                    PuzzleSquare square = new PuzzleSquare(normalImages[index], index)
                    {
                        Row = row,
                        Col = col
                    };



                    // Add tap recognition
                    TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer
                    {
                        Command = new Command(OnSquareTapped),
                        CommandParameter = square
                    };
                    square.GestureRecognizers.Add(tapGestureRecognizer);

                    //Bitmap bitmap = BitmapFactory.DecodeFile("Puzzles.test.png");
                    //cropBitmap(bitmap, Convert.ToInt32(square.WidthRequest), Convert.ToInt32(square.HeightRequest));
                    // Add it to the array and the AbsoluteLayout.
                    squares[row, col] = square;

                    absoluteLayout.Children.Add(square);
                    index++;
                }
            }


            // This is the "Randomize" button.
            randomizeButton = new Xamarin.Forms.Button
            {
                Text = "Randomize",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            randomizeButton.Clicked += OnRandomizeButtonClicked;

            // Label to display elapsed time.
            timeLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };


            // Put everything in a StackLayout.
            stackLayout = new StackLayout
            {
                Children = {
                                    new StackLayout {
                                        VerticalOptions = LayoutOptions.FillAndExpand,
                                        HorizontalOptions = LayoutOptions.FillAndExpand,
                                        Children = {
                                            randomizeButton,
                                            timeLabel,


                                        }
                                    },
                                    absoluteLayout
                                }



            };
            stackLayout.SizeChanged += OnStackSizeChanged;

            // And set that to the content of the page.
            this.Padding =
                new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            this.Content = stackLayout;
        }



        void OnStackSizeChanged(object sender, EventArgs args)
        {
            double width = stackLayout.Width;
            double height = stackLayout.Height;

            if (width <= 0 || height <= 0)
                return;



            // Orient StackLayout based on portrait/landscape mode.
            stackLayout.Orientation = (width < height) ? StackOrientation.Vertical :
                                                         StackOrientation.Horizontal;

            // Calculate square size and position based on stack size.
            squareSize = Math.Min(width, height) / NUM;
            absoluteLayout.WidthRequest = NUM * squareSize;
            absoluteLayout.HeightRequest = NUM * squareSize;

            foreach (View view in absoluteLayout.Children)
            {
                PuzzleSquare square = (PuzzleSquare)view;


                Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(square,
                    new Rectangle(square.Col * squareSize,
                        square.Row * squareSize,
                        squareSize,
                        squareSize));
            }


        }

        async void OnSquareTapped(object parameter)
        {
            PuzzleSquare tappedSquare = (PuzzleSquare)parameter;
            await ShiftIntoEmpty(tappedSquare.Row, tappedSquare.Col);

            // Check for a "win". 
            int index;

            for (index = 0; index < NUM * NUM - 1; index++)
            {
                int row = index / NUM;
                int col = index % NUM;
                PuzzleSquare square = squares[row, col];
                if (square == null || square.Index != index)
                    break;
            }

            // We have a winner! 
            if (index == NUM * NUM - 1)
            {
                isPlaying = false;
                await DisplayAlert("CONGRATULATION", "YOU WON", "OK");
            }
        }


        async Task ShiftIntoEmpty(int tappedRow, int tappedCol, uint length = 100)
        {
            // Shift columns.
            if (tappedRow == emptyRow && tappedCol != emptyCol)
            {
                int inc = Math.Sign(tappedCol - emptyCol);
                int begCol = emptyCol + inc;
                int endCol = tappedCol + inc;

                for (int col = begCol; col != endCol; col += inc)
                {
                    await AnimateSquare(emptyRow, col, emptyRow, emptyCol, length);
                }
            }
            // Shift rows.
            else if (tappedCol == emptyCol && tappedRow != emptyRow)
            {
                int inc = Math.Sign(tappedRow - emptyRow);
                int begRow = emptyRow + inc;
                int endRow = tappedRow + inc;

                for (int row = begRow; row != endRow; row += inc)
                {
                    await AnimateSquare(row, emptyCol, emptyRow, emptyCol, length);
                }
            }
        }

        async Task AnimateSquare(int row, int col, int newRow, int newCol, uint length)
        {
            // The Square to be animated.
            PuzzleSquare animaSquare = squares[row, col];


            // The destination rectangle.
            Rectangle rect = new Rectangle(squareSize * emptyCol,
                                          squareSize * emptyRow,
                                          squareSize,
                                          squareSize);


            // This is the actual animation call.
            await animaSquare.LayoutTo(rect, length);

            // Set several variables and properties for new layout.
            squares[newRow, newCol] = animaSquare;
            animaSquare.Row = newRow;
            animaSquare.Col = newCol;
            squares[row, col] = null;
            emptyRow = row;
            emptyCol = col;
        }

        async void OnRandomizeButtonClicked(object sender, EventArgs args)
        {
            Xamarin.Forms.Button button = (Xamarin.Forms.Button)sender;
            button.IsEnabled = false;
            Random rand = new Random();

            isBusy = true;

            // Simulate some fast crazy taps.
            for (int i = 0; i < 100; i++)
            {
                await ShiftIntoEmpty(rand.Next(NUM), emptyCol, 25);
                await ShiftIntoEmpty(emptyRow, rand.Next(NUM), 25);
            }
            button.IsEnabled = true;

            isBusy = false;

            // Prepare for playing.
            DateTime startTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // Round duration and get rid of milliseconds.
                TimeSpan timeSpan = (DateTime.Now - startTime) +
                                            TimeSpan.FromSeconds(0.5);
                timeSpan = new TimeSpan(timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

                // Display the duration.
                if (isPlaying)
                    timeLabel.Text = timeSpan.ToString("t");
                return isPlaying;
            });
            this.isPlaying = true;
        }

        async Task DoWinAnimation()
        {
            // Inhibit all input.
            randomizeButton.IsEnabled = false;
            isBusy = true;

            for (int cycle = 0; cycle < 2; cycle++)
            {
                foreach (PuzzleSquare square in squares)
                    if (square != null)
                        await square.AnimateWinAsync(cycle == 1);

                if (cycle == 0)
                    await Task.Delay(1500);
            }

            // All input.
            randomizeButton.IsEnabled = true;
            isBusy = false;
        }

        public static Bitmap cropBitmap(Bitmap original, int height, int width)
        {
            Bitmap croppedImage = Bitmap.CreateBitmap(width, height, Bitmap.Config.Rgb565);
            Canvas canvas = new Canvas(croppedImage);

            Rect srcRect = new Rect(0, 0, original.Width, original.Height);
            Rect dstRect = new Rect(0, 0, width, height);

            int dx = (srcRect.Width() - dstRect.Width()) / 2;
            int dy = (srcRect.Height() - dstRect.Height()) / 2;

            // If the srcRect is too big, use the center part of it.
            srcRect.Inset(Math.Max(0, dx), Math.Max(0, dy));

            // If the dstRect is too big, use the center part of it.
            dstRect.Inset(Math.Max(0, -dx), Math.Max(0, -dy));

            // Draw the cropped bitmap in the center
            canvas.DrawBitmap(original, srcRect, dstRect, null);

            original.Recycle();

            return croppedImage;
        }







        //Android.Graphics.Path puzzlePath;

        //private Bitmap getPuzzleBitmap(Bitmap bitmap)
        //{
        //    Bitmap output = Bitmap.CreateBitmap(bitmap.Width, bitmap.Height, Bitmap.Config.Argb8888);
        //    Canvas canvas = new Canvas(output);


        //    Paint paint = new Paint();
        //    Rect rect = new Rect(0, 0, bitmap.Width, bitmap.Height);

        //    calculatePuzzlePath(bitmap.Width, bitmap.Height);


        //    canvas.DrawARGB(0, 0, 0, 0);

        //    canvas.DrawPath(puzzlePath, paint);

        //    paint.SetXfermode(new PorterDuffXfermode(PorterDuff.Mode.SrcIn));
        //    canvas.DrawBitmap(bitmap, rect, rect, paint);

        //    return output;
        //}

        //private void calculatePuzzlePath(int width, int height)
        //{
        //    float radius = (height / 2) - 5;
        //    float smallRadius = radius / 3;
        //    radius -= smallRadius * 2;
        //    float centerX = width / 2;
        //    float centerY = height / 2;
        //    Android.Graphics.Path puzzlePath = new Android.Graphics.Path();
        //    // Bottom right
        //    puzzlePath.MoveTo(centerX + radius, centerY + radius);
        //    // Top right
        //    puzzlePath.LineTo(centerX + radius, centerY - radius);
        //    // Center top
        //    puzzlePath.LineTo(centerX, centerY - radius);
        //    // Add outside circle to center top
        //    puzzlePath.AddCircle(centerX, centerY - radius - ((radius / 3) / 2), radius / 3, Android.Graphics.Path.Direction.Ccw);

        //    // Top left
        //    puzzlePath.LineTo(centerX - radius, centerY - radius);
        //    // Bottom left
        //    puzzlePath.LineTo(centerX - radius, centerY + radius);
        //    //Bottom right
        //    puzzlePath.LineTo(centerX + radius, centerY + radius);
        //}

        //private void SplitImage(Bitmap _thePicture)
        //{
        //    Bitmap[,] imgs;

        //    imgs = new Bitmap[3, 3];
        //    int width, height;
        //    width = _thePicture.Width / 3;
        //    height = _thePicture.Height / 3;

        //    for (int x = 0; x < 3; ++x)
        //    {
        //        for (int y = 0; y < 3; ++y)
        //        {

        //            // Create the sliced bitmap
        //            imgs[x, y] = Bitmap.CreateBitmap(_thePicture, x * width, y * height, width, height);
        //        }
        //    }


        }

    }














