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

namespace PassBetween1
{
    [Activity(Label = "Second")]
    public class Second : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.SecondScreen);

            string passedText = Intent.GetStringExtra("PassedVal");

            if (string.IsNullOrEmpty(passedText) || string.IsNullOrWhiteSpace(passedText))
            {
                passedText = "No value passed";
            }

            TextView txtBox = FindViewById<TextView>(Resource.Id.textView1);
            txtBox.Text = passedText;
        }
    }
}