using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;

namespace JumpingBall
{
    [Activity(Label = "JumpingBall", MainLauncher = true)]
    public class MainActivity : Activity
    {
        MovingCanvas mc;
        Handler h = new Handler();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mc = FindViewById<MovingCanvas>(Resource.Id.mc);
            h.PostDelayed(new UpdateTask(this), 1000);
        }

        private class UpdateTask : Java.Lang.Object, IRunnable
        {
            MainActivity m;

            public UpdateTask(MainActivity ma)
            {
                m = ma;
            }

            public void Run()
            {
                m.mc.B.Update(m.mc.Height);
                m.mc.Invalidate();
                m.h.PostDelayed(new UpdateTask(m), 1000);
            }
        }
    }
}

