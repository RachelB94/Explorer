
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Explorer
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        EditText username;
        EditText password;
        Button btncreate;
        Button btnsign;

   
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Login);
            btnsign = FindViewById<Button>(Resource.Id.btnLogin);
            btncreate = FindViewById<Button>(Resource.Id.btnRegister);
            username = FindViewById<EditText>(Resource.Id.username);
            password = FindViewById<EditText>(Resource.Id.password);
            btncreate.Click += create;
            btnsign.Click += signin;

            // Create your application here
        }

        private async void signin(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var uri = new Uri(string.Format("http://explorerlogin20170201121708.azurewebsites.net/api/Login?username=" + username.Text + "&password=" + password.Text));
            HttpResponseMessage response;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            response = await client.GetAsync(uri);
            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                var errorMessage1 = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                    {
                        '"'
                    });
                Toast.MakeText(this, errorMessage1, ToastLength.Long).Show();
            }
            else
            {
                var errorMessage1 = response.Content.ReadAsStringAsync().Result.Replace("\\", "").Trim(new char[1]
                {
                    '"'
                });
            }

            StartActivity(typeof(MainActivity));

        }

        private void create(object sender, EventArgs e)
        {
            StartActivity(typeof(NewUser));
        }
    }
}