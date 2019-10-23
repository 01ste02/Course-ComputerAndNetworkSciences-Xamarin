using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Intent
{
    [Activity(Label = "IntentsSamples", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // Get our button from the layout resource,button name is MyButton
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += button_Click;
        }
        private void button_Click(object sender, EventArgs e)
        {
            var detailsIntent = new Android.Content.Intent(this, typeof(SecondActivity));

            StartActivity(detailsIntent);
        }
    }
}


