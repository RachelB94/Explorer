using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Puzzles;
using Android.Graphics;

namespace Explorer
{
    [Activity(Label = "Puzzle")]
    public class Puzzle : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
         

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new AppPuzzle());
        }
    }
}