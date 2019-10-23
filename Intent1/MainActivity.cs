using Android.App;
using Android.Widget;
using Android.OS;

namespace Intent1
{
    [Activity(Label = "Intent1", MainLauncher = true)]
    public class MainActivity : Activity, RadioGroup.IOnCheckedChangeListener
    {
        public void OnCheckedChanged(RadioGroup group, int checkedId)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            RadioGroup rg1 = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            rg1.SetOnCheckedChangeListener(this);
        }
    }
}

