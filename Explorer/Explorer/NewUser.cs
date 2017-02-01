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
using System.Net.Http;
using Newtonsoft.Json;

namespace Explorer
{
    [Activity(Label = "NewUser")]
    public class NewUser : Activity
    {
        EditText username;
        EditText password;
        Button create;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);
            username = FindViewById<EditText>(Resource.Id.username);
            password = FindViewById<EditText>(Resource.Id.password);
            create = FindViewById<Button>(Resource.Id.btnlogin2);
            create.Click += create_click;


        }

        private async void create_click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.username = username.Text;
            log.password = password.Text;
            HttpClient Client = new HttpClient();
            string url = "http://explorerlogin20170201121708.azurewebsites.net/api/Values";
            var uri = new Uri(url);
            Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response;
            var json = JsonConvert.SerializeObject(log);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            response = await Client.PostAsync(uri, content);
            if(response.StatusCode == System.Net.HttpStatusCode.Accepted)
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
                Toast.MakeText(this, errorMessage1, ToastLength.Long).Show();
            }

        }
    }
}