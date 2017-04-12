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
using ExplorerVision;
using Android.Support.V4.App;


namespace Explorer
{
    [Activity(Label = "Camera", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class Camera : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());

           
            // Create your application here
        }


    }
}