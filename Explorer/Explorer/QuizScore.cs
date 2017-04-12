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
    [Activity(Label = "QuizScore", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class QuizScore : Activity
    {
       
        Quiz q = new Quiz();
        protected override void OnCreate(Bundle savedInstanceState)
        {
          
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.QuizScore);
            
            TextView tv = FindViewById<TextView>(Resource.Id.score);
            string score = Intent.GetStringExtra("Score");
            tv.Text = score + " / " + 10;

            ImageView image = FindViewById<ImageView>(Resource.Id.medal);
            if (score.Equals("8") || score.Equals("9") || score.Equals("10")) 
            {
                image.SetImageResource(Resource.Drawable.goldmedal);
            }
            if(score.Equals("7") && score.Equals("6") && score.Equals("5"))
            {
               
            }
            if(score.Equals("4") && score.Equals("3") && score.Equals("2"))
            { }

            Button retake = FindViewById<Button>(Resource.Id.retake);
            retake.Click += delegate
            {
                StartActivity(typeof(Quiz));
            };

            Button cancel = FindViewById<Button>(Resource.Id.cancel);
            cancel.Click += delegate
            {
                StartActivity(typeof(MainActivity));
            };
                
            
        }
    }
}