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

namespace Explorer
{
    [Activity(Label = "Levels")]
    public class Levels : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.Levels);


            PuzzlePage page = new PuzzlePage();

            Button easybtn = FindViewById<Button>(Resource.Id.easy);
            easybtn.Click += delegate
            {

                page.SetLevel(2);
                StartActivity(typeof(Puzzle));


            };

            Button mediumbtn = FindViewById<Button>(Resource.Id.medium);
            mediumbtn.Click += delegate
            {


                page.SetLevel(4);
                StartActivity(typeof(Puzzle));


            };

            Button hardbtn = FindViewById<Button>(Resource.Id.hard);
            hardbtn.Click += delegate
            {


                page.SetLevel(5);
                StartActivity(typeof(Puzzle));


            };





        }

    }
}
