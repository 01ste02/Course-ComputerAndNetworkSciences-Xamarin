using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Graphics;
using System;

namespace InputHandling
{
    [Activity(Label = "InputHandling", MainLauncher = true)]
    public class MainActivity : Activity, View.IOnClickListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btnTest = FindViewById<Button>(Resource.Id.button2);
            btnTest.Click += Btn2Click;

            Button btn3 = FindViewById<Button>(Resource.Id.button3);
            btn3.SetOnClickListener(this);
        }

        private void Btn2Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Random r = new Random();
            btn.SetBackgroundColor(Color.Rgb(r.Next(255), r.Next(255), r.Next(255)));
        }

        [Java.Interop.Export("OnClickView")]
        public void OnClickView(View v)
        {
            LinearLayout test = FindViewById<LinearLayout>(Resource.Id.layoutMain);
            Random r = new Random();
            test.SetBackgroundColor(Color.Rgb(r.Next(255), r.Next(255), r.Next(255)));
        }

        public void OnClick(View v)
        {
            Button btnOne = FindViewById<Button>(Resource.Id.button1);
            Random r = new Random();
            btnOne.SetBackgroundColor(Color.Rgb(r.Next(255), r.Next(255), r.Next(255)));
        }
    }
}

