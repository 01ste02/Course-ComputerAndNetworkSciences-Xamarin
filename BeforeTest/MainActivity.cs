using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using static Android.Views.View;
using Android.Content;

namespace BeforeTest
{
    [Activity(Label = "BeforeTest", MainLauncher = true)]
    public class MainActivity : Activity, IOnClickListener
    {
        Button btn;
        EditText num2;
        EditText num1;

        public void OnClick(View v)
        {
            if (v.Id == btn.Id)
            {
                int number1 = int.Parse(num2.Text);
                int number2 = int.Parse(num1.Text);

                int added = number1 + number2;

                Intent intent = new Intent(this, typeof(Second));
                intent.PutExtra("addedNum", added);

                StartActivity(intent);
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btn = FindViewById<Button>(Resource.Id.button1);
            num2 = FindViewById<EditText>(Resource.Id.editText1);
            num1 = FindViewById<EditText>(Resource.Id.editText2);

            btn.SetOnClickListener(this);
        }
    }
}

