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

namespace Explorer
{
    [Activity(Label = "QuizScore")]
    public class QuizScore : Activity
    {
       
        Quiz q = new Quiz();
        protected override void OnCreate(Bundle savedInstanceState)
        {
          
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.QuizScore);
            
            TextView tv = FindViewById<TextView>(Resource.Id.score);
            string score = Intent.GetStringExtra("Score");
            tv.Text = score;
        }
    }
}