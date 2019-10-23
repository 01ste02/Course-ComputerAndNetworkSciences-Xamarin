using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content;

namespace PassBetween
{
    [Activity(Label = "PassBetween", MainLauncher = true)]
    public class MainActivity : Activity, View.IOnClickListener
    {
        Button btnStartSecond;
        EditText txtInput;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btnStartSecond = FindViewById<Button>(Resource.Id.button1);
            btnStartSecond.SetOnClickListener(this);

            txtInput = FindViewById<EditText>(Resource.Id.editText1);
        }

        public void OnClick(View v)
        {
            Intent intent = new Intent(this, typeof(SecondScreen));
            intent.PutExtra("PassString", txtInput.Text);
            StartActivity(intent);
        }
    }
}

