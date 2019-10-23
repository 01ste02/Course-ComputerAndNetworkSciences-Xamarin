using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Views.Animations;

namespace OwnComponent
{
    [Activity(Label = "OwnComponent", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView tw;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            tw = FindViewById<TextView>(Resource.Id.textView1);
            Animation anim = AnimationUtils.LoadAnimation(ApplicationContext, Resource.Animation.fade);

            tw.StartAnimation(anim);
        }
    }
}

