using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Puzzles
{
    class PuzzleSquare : ContentView
    {
       

       
        //public PuzzleSquare(int row, int col, ImageSource imageSource)
        //{
        //    Row = row;
        //    Col = col;

        //    Padding = new Thickness(1);
        //    Content = new Image
        //    {
        //        Source = imageSource
        //    };
        //}

        //public int Row { set; get; }

        //public int Col { set; get; }

        //private Image image;

        //public int Index
        //{
        //    get;
        //    set;
        //}


        //public Image NormalImage
        //{
        //    get;
        //    set;
        //}
        //public int Row { get; internal set; }
        //public int Col { get; internal set; }

        //public PuzzleSquare(Image normal, int index)
        //{
        //    Index = index;
        //    NormalImage = normal;


        //   Image ShownImage = new Image
        //    {
        //        Source = NormalImage.Source
        //    };

        //    this.Content = new Frame
        //    {
        //        OutlineColor = Color.Accent,
        //        Content = new StackLayout
        //        {
        //            Children = {
        //        ShownImage
        //    }
        //        }
        //    };

        //    this.BackgroundColor = Color.Transparent;
        //}



        Label label = new Label();
        Image text { get; set; }


       

        public PuzzleSquare(Image imageSource, int index)
        {
            this.Index = index;
            text = imageSource;

            Image shown = new Image
            {
                Source = text.Source
            };

          
            // A Frame surrounding two Labels.
            label = new Label
            {
                
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            

            Label tinyLabel = new Label
            {
                Text = (index + 1).ToString(),
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalOptions = LayoutOptions.End
            };

        

            this.Padding = new Thickness(3);
            this.Content = new Frame
            {
                OutlineColor = Xamarin.Forms.Color.Accent,
                Padding = new Thickness(5, 10, 5, 0),
                Content = new StackLayout
                {
                    Spacing = 0,
                    Children = {
                                shown,
                                tinyLabel,
                                
                            }
                }
            };

            // Don't let touch pass us by.
            this.BackgroundColor = Xamarin.Forms.Color.Transparent;
        }



        // Retain current Row and Col position.
        public int Index { private set; get; }

        public int Row { set; get; }

        public int Col { set; get; }

        public async Task AnimateWinAsync(bool isReverse)
        {
            uint length = 150;
            await Task.WhenAll(this.ScaleTo(3, length), this.RotateTo(180, length));
            await Task.WhenAll(this.ScaleTo(1, length), this.RotateTo(360, length));
            this.Rotation = 0;
        }

        public void SetLabelFont(double fontSize, FontAttributes attributes)
        {
            label.FontSize = fontSize;
            label.FontAttributes = attributes;
        }
    }

}



