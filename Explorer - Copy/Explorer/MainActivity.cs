using Android.App;
using Android.Widget;
using Android.OS;

namespace Explorer
{
    [Activity(Label = "Explorer", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            Button buttonCamera = FindViewById<Button>(Resource.Id.Camera);
            buttonCamera.Click += delegate
            {
                StartActivity(typeof(Camera));
            };

        }
    }
}


