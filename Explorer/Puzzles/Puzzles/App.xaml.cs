using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Puzzles
{
    public partial class AppPuzzle : Application
    {
        public AppPuzzle()
        {
            InitializeComponent();

          
            MainPage = new PuzzlePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
