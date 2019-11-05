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

namespace BeforeTest
{
    [Activity(Label = "Second")]
    public class Second : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout_2);

            int added = Intent.GetIntExtra("addedNum", 0);

            TextView txt = FindViewById<TextView>(Resource.Id.textView1);

            txt.Text = added.ToString();

            // Create your application here
        }
    }
}