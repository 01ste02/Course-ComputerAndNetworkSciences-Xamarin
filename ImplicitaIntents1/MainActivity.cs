using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Uri = Android.Net.Uri;
using Android.Views;
using Android.Provider;

namespace ImplicitaIntents1
{
    [Activity(Label = "ImplicitaIntents1", MainLauncher = true)]
    public class MainActivity : Activity, View.IOnClickListener
    {
        Button btnTimer;
        Button btnCamera;
        Button btnMedia;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btnTimer = FindViewById<Button>(Resource.Id.button1);
            btnTimer.SetOnClickListener(this);

            btnCamera = FindViewById<Button>(Resource.Id.button2);
            btnCamera.SetOnClickListener(this);

            btnMedia = FindViewById<Button>(Resource.Id.button3);
            btnMedia.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            if(v.Id == btnTimer.Id)
            {
                startTimer("Go to HELL!", 10);
            }
            else if (v.Id == btnCamera.Id)
            {
                capturePhoto();
            }
            else
            {
                showVideo();
            }
        }

        public void startTimer(String message, int seconds)
        {
            Intent intent = new Intent(AlarmClock.ActionSetTimer)
                    .PutExtra(AlarmClock.ExtraMessage, message)
                    .PutExtra(AlarmClock.ExtraLength, seconds)
                    .PutExtra(AlarmClock.ExtraSkipUi, true);
            //det handlar om timer, som har texten - message och avfyras efter seconds
            if (intent.ResolveActivity(this.PackageManager) != null)//felhantering 
            {
                StartActivity(intent);//ny activity visas
            }
        }

        public void capturePhoto()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            if (intent.ResolveActivity(this.PackageManager) != null)
            {
                int mRequestCode = 0;
                StartActivityForResult(intent, mRequestCode);
            }
        }

        public void showVideo()
        {
            Uri uri = Uri.Parse("https://www.youtube.com/watch?v=kzH1iaKVsBM");
            Intent video = new Intent(Intent.ActionView, uri);
            StartActivity(video);
        }
    }
}

