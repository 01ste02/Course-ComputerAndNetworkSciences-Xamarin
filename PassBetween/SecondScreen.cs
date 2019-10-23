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

namespace PassBetween
{
    [Activity(Label = "SecondScreen")]
    public class SecondScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SecondScreen);

            TextView txtView = FindViewById<TextView>(Resource.Id.textView1);

            String passedData = Intent.GetStringExtra("PassString");

            if (string.IsNullOrEmpty(passedData) || string.IsNullOrWhiteSpace(passedData))
            {
                passedData = "No text was passed from the first screen.";
            }

            txtView.Text = passedData;
        }
    }
}