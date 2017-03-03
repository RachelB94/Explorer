using System;
using Xamarin.Forms;

namespace Puzzles
{
    internal class BitmapImage : ImageSource
    {
        private Uri uri;

        public BitmapImage(Uri uri)
        {
            this.uri = uri;
        }
    }
}