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
using Puzzles;
using Android.Graphics;
using OpenCV.Android;
using OpenCV.Core;

namespace Explorer
{
    //    [Activity(Label = "Puzzle")]
    //    public class Puzzle : Activity, CameraBridgeViewBase.ICvCameraViewListener, ILoaderCallbackInterface, View.IOnTouchListener
    //    {
    //        private int _gameWidth;
    //        private int _gameHeight;
    //        private IMenuItem _itemHideNumbers;
    //        private IMenuItem _itemStartNewGame;
    //        private CameraBridgeViewBase _openCvCameraView;
    //        private PuzzleProcess _puzzle15;

    //        protected override void OnCreate(Bundle savedInstanceState)
    //        {
    //            base.OnCreate(savedInstanceState);
    //            Window.AddFlags(WindowManagerFlags.KeepScreenOn);
    //            _openCvCameraView = new JavaCameraView(this, -1) as CameraBridgeViewBase;
    //            SetContentView(_openCvCameraView);
    //            _openCvCameraView.Visibility = ViewStates.Visible;
    //            _openCvCameraView.SetCvCameraViewListener(this);
    //            _puzzle15 = new PuzzleProcess();
    //            _puzzle15.PrepareNewGame();
    //        }

    //        protected override void OnPause()
    //        {
    //            base.OnPause();
    //            if (_openCvCameraView != null)
    //            {
    //                _openCvCameraView.DisableView();
    //            }
    //        }

    //        protected override void OnResume()
    //        {
    //            base.OnResume();
    //            if (!OpenCVLoader.InitDebug())
    //            {

    //                OpenCVLoader.InitAsync(OpenCVLoader.OpencvVersion300, this, this);
    //            }
    //            else
    //            {

    //                OnManagerConnected(LoaderCallbackInterface.Success);
    //            }
    //        }

    //        protected override void OnDestroy()
    //        {
    //            base.OnDestroy();
    //            if (_openCvCameraView != null)
    //            {
    //                _openCvCameraView.DisableView();
    //            }
    //        }

    //        public override bool OnCreateOptionsMenu(IMenu menu)
    //        {

    //            _itemHideNumbers = menu.Add("Show/hide tile members");
    //            _itemStartNewGame = menu.Add("Start new game");
    //            return true;
    //        }

    //        public override bool OnOptionsItemSelected(IMenuItem item)
    //        {


    //            if (item == _itemStartNewGame)
    //            {
    //                _puzzle15.PrepareNewGame();
    //            }
    //            else if (item == _itemHideNumbers)
    //            {
    //                _puzzle15.ToggleTileNumbers();
    //            }

    //            return true;
    //        }

    //        public Mat OnCameraFrame(Mat p0)
    //        {

    //            return _puzzle15.PuzzleFrame(p0);
    //        }

    //        public void OnCameraViewStarted(int p0, int p1)
    //        {
    //            _gameWidth = p0;
    //            _gameHeight = p1;
    //            _puzzle15.PrepareGameSize(p0, p1);
    //        }

    //        public void OnCameraViewStopped()
    //        {
    //        }

    //        public void OnManagerConnected(int p0)
    //        {
    //            switch (p0)
    //            {
    //                case LoaderCallbackInterface.Success:
    //                    _openCvCameraView.SetOnTouchListener(this);
    //                    _openCvCameraView.EnableView();
    //                    break;
    //                default:
    //                    break;
    //            }
    //        }

    //        public void OnPackageInstall(int p0, IInstallCallbackInterface p1)
    //        {
    //        }

    //        public bool OnTouch(View v, MotionEvent e)
    //        {
    //            int xpos, ypos;

    //            xpos = (v.Width - _gameWidth) / 2;
    //            xpos = (int)e.GetX() - xpos;

    //            ypos = (v.Height - _gameHeight) / 2;
    //            ypos = (int)e.GetY() - ypos;

    //            if (xpos >= 0 && xpos <= _gameWidth && ypos >= 0 && ypos <= _gameHeight)
    //            {
    //                /* click is inside the picture. Deliver this event to processor */
    //                _puzzle15.DeliverTouchEvent(xpos, ypos);
    //            }

    //            return false;
    //        }
    //    }
    //}



    [Activity(Label = "Puzzle", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class Puzzle : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);


            LoadApplication(new AppPuzzle());
        }
    }
}




