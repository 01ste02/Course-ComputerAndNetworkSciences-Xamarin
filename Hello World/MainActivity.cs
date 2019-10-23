using Android.App;
using Android.Widget;
using Android.OS;

namespace Hello_World
{
    [Activity(Label = "Hello_World", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.relativeLayout2);
        }
    }
}

