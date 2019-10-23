using Android.App;
using Android.Widget;
using Android.OS;

namespace ToastAndSnackbars
{
    [Activity(Label = "ToastAndSnackbars", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

