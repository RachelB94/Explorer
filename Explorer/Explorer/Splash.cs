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
using Java.Lang;

namespace Explorer
{
    [Activity(Label = "Explorer", MainLauncher=true,Theme="@style/Theme.Splash",NoHistory=true,Icon="@drawable/icon")]
    public class Splash : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Thread.Sleep(4000);
            StartActivity(typeof(LoginActivity));

        }
    }
}