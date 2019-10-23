using Android.App;
using Android.Widget;
using Android.OS;
using Android;

namespace LifeCycle
{
    [Activity(Label = "LifeCycle", MainLauncher = true)]
    public class MainActivity : Activity
    {

        EditText txtMsg;
        Button btnFinish;
        TextView txtToDo;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            txtMsg = FindViewById<EditText>(Resource.Id.txtMsg);
            txtToDo = FindViewById<TextView>(Resource.Id.txtToDo);

            string msg = "Instructions:                	                 \n "
                    + "0. New instance (onCreate, onStart, onResume)   \n "
                    + "1. Back Arrow   (onPause, onStop, onDestroy)    \n "
                    + "2. Finish       (onPause, onStop, onDestroy)    \n "
                    + "3. Home		 (onPause, onStop)	 \n "
                    + "4. After 3> App Tab> re-execute current app     \n "
                    + "  (onRestart, onStart, onResume)		 \n "
                    + "5. Enter some data - repeat steps 1-4   	 \n ";

            txtToDo.Text = msg;
            btnFinish = FindViewById<Button>(Resource.Id.btnFinish);
            btnFinish.Click += BtnFinish_Click;
            Toast.MakeText(this, "onCreate ...", ToastLength.Long)
                .Show();

        }//onCreate

        private void BtnFinish_Click(object sender, System.EventArgs e)
        {
            Finish();

        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
            Toast.MakeText(BaseContext, "onDestroy ...", ToastLength.Long).Show();
        }
        protected override void OnPause()
        {
            base.OnPause();
            Toast.MakeText(this, "onPause ...", ToastLength.Long).Show();

        }

        protected override void OnRestart()
        {
            base.OnRestart();
            Toast.MakeText(BaseContext, "onRestart ...", ToastLength.Long).Show();
        }

        protected override void OnResume()
        {
            base.OnResume();
            Toast.MakeText(BaseContext, "onResume...", ToastLength.Long).Show();
        }



        protected override void OnStart()
        {
            base.OnStart();
            Toast.MakeText(BaseContext, "onStart ...", ToastLength.Long).Show();
        }

        protected override void OnStop()
        {
            base.OnStop();
            Toast.MakeText(BaseContext, "onStop ...", ToastLength.Long).Show();
        }

        /*
        * protected void onSaveInstanceState(Bundle outState)
        * Called to retrieve per-instance state from an activity 
        */

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            Toast.MakeText(BaseContext, "onSaveInstanceState ...BUNDLING",
                    ToastLength.Long).Show();
        } // onSaveInstanceState

    }
}
