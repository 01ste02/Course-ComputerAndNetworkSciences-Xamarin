using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Uri = Android.Net.Uri;

namespace ImplicitaIntents
{
    [Activity(Label = "ImplicitaIntents", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btnPolhem = FindViewById<Button>(Resource.Id.button1);
            btnPolhem.Click += OpenPolhem_Click;

            Button btnSecret = FindViewById<Button>(Resource.Id.button2);
            btnSecret.Click += CallSecretService_Click;

            Button btnLocation = FindViewById<Button>(Resource.Id.button3);
            btnLocation.Click += OpenLocation_Click;
        }

        public void OpenPolhem_Click (Object sender, EventArgs e)
        {
            Uri uri = Uri.Parse("http://polhem.com/");
            Intent polhem = new Intent(Intent.ActionView, uri);
            StartActivity(polhem);
        }

        public void CallSecretService_Click (Object sender, EventArgs e)
        {
            Uri uri = Uri.Parse("tel:2024065708");
            Intent call = new Intent(Intent.ActionDial, uri);
            StartActivity(call);
        }

        public void OpenLocation_Click (Object sender, EventArgs e)
        {
            Uri uri = Uri.Parse("geo:12.3703666,23.3222222");
            Intent location = new Intent(Intent.ActionView, uri);
            StartActivity(location);
        }
    }
}

