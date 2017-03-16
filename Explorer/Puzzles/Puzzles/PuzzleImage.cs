using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Puzzles
{
    class PuzzleImage : Image
    {
        public Image[,] MatrixImage { get; set; }
        PuzzleImage orignalImage;

        Bitmap originalBitmap = BitmapFactory.DecodeFile("Puzzles.test.png");

       
        [assembly:ExportRender(typeof(PuzzleImage), typeof(PuzzleImageRenderer))]
        public PuzzleImage()
        {

            int Height, Width;
            Height = 150;
            Width = 150;
            using (Bitmap bitmap = originalBitmap)
            {
                int minDimension = 0;
                if(bitmap.Height <= bitmap.Width)
                {
                    minDimension = bitmap.Height;
                }
                else
                {
                    minDimension = bitmap.Width;
                }

                Bitmap finalBitmap = null;
                finalBitmap = Bitmap.CreateBitmap(bitmap, 0, 0, minDimension, minDimension);

                int squareSize = minDimension / 4;
                orignalImage.MatrixImage = new Image[4, 4];
                for (int col = 0; col < 4; col++)
                {
                    for(int row = 0; row < 4; row++)
                    {
                        Bitmap bmp = Bitmap.CreateBitmap(finalBitmap, row * squareSize, col * squareSize, minDimension, minDimension);
                        orignalImage.MatrixImage[row, col] = new Image()
                        {
                            Source = ImageSource.FromResource("Puzzles.test.png")
                        };
              
                        }
                    }
                }
                
            }
        }
    }

