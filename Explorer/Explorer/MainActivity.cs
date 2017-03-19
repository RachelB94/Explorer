using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V4.App;


namespace Explorer
{
    [Activity(Label = "Explorer", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);
            Button buttonCamera = FindViewById<Button>(Resource.Id.Camera);
            buttonCamera.Click += delegate
            {
                StartActivity(typeof(Camera));
            };

            Button buttonPuzzle = FindViewById<Button>(Resource.Id.Puzzle);
            buttonPuzzle.Click += delegate
            {
                StartActivity(typeof(Levels));
            };

        }
    }
}


