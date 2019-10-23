using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;
using Android.Graphics;

namespace LifeCycle1
{
    [Activity(Label = "LifeCycle1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MediaPlayer mediaPlayer;
        LinearLayout linearLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            linearLayout = FindViewById<LinearLayout>(Resource.Id.layout1);

            
            mediaPlayer = MediaPlayer.Create(this, Resource.Raw.holiday);
            mediaPlayer.Start();

            linearLayout.SetBackgroundColor(Color.Green);
        }

        protected override void OnResume()
        {
            base.OnResume();
            mediaPlayer.Start();
            linearLayout.SetBackgroundColor(Color.Green);
        }

        protected override void OnPause()
        {
            base.OnPause();
            mediaPlayer.Pause();
            linearLayout.SetBackgroundColor(Color.Black);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            mediaPlayer.Release();
        }
    }
}

