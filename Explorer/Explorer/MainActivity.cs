using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.V4.App;


namespace Explorer
{
    [Activity(Label = "Explorer", Icon = "@drawable/icon", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        // private EditText name, email;
        //private ListView list;
        //private ProgressBar bar;

        //private List<Account> list = new List<Account>();
        //private ListView adapter;
        //private Account selectedAccount;

        //private const string FirebaseUrl = "https://explorer-13266.firebaseio.com/";

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

            Button buttonQuiz = FindViewById<Button>(Resource.Id.Quiz);
            buttonQuiz.Click += delegate
            {
                StartActivity(typeof(Quiz));
            };

            Button buttonGallery = FindViewById<Button>(Resource.Id.Gallery);
            buttonGallery.Click += delegate
            {
                StartActivity(typeof(GalleryActivity));
            };


        }

       // public TaskStackBuilder LoadData
        //{
          //  circle_progress.Visibility = ViewStates.Visible;
            //list_data.visibility = ViewStates.visible;

            //var firebase = new FirebaseClient(FirebaseUrl);
        //var items = await Firebase.Child("users")
        //.OnceAsync<Account>();
       // list_users.clear();
    //}
}
}


