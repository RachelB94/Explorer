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
    [Activity(Label = "Gallery")]
    public class GalleryActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Gallary);
            Gallery gallery = FindViewById<Gallery>(Resource.Id.gallery);
            gallery.Adapter = new ImageAdapter(this);
            gallery.ItemClick += delegate (object sender, Android.Widget.AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
                // Create your application here
            };
           }
    }
}