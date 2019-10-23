using Android.App;
using Android.OS;

namespace Intent
{
    [Activity(Label = "DetailsActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Second);
        }
    }
}
