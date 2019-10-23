using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;
using Uri = Android.Net.Uri;

namespace PassBetween1
{
    [Activity(Label = "PassBetween1", MainLauncher = true)]
    public class MainActivity : Activity, View.IOnClickListener
    {
        Button btnPlay;
        Button btnStartSecond;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btnPlay = FindViewById<Button>(Resource.Id.button1);
            btnStartSecond = FindViewById<Button>(Resource.Id.button2);

            btnPlay.SetOnClickListener(this);
            btnStartSecond.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            if (v.Id == btnPlay.Id)
            {
                Uri uri = Uri.Parse("https://www.youtube.com/watch?v=1vrEljMfXYo");
                var intent = new Intent(Intent.ActionView, uri);
                StartActivity(intent);
            }
            else
            {
                EditText txtBox = FindViewById<EditText>(Resource.Id.editText1);
                Intent intent = new Intent(this, typeof(Second));
                intent.PutExtra("PassedVal", txtBox.Text);

                StartActivity(intent);
            }
        }
    }
}

