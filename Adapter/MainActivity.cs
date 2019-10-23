using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace Adapter
{
    [Activity(Label = "Adapter", MainLauncher = true)]
    public class MainActivity : Activity, AdapterView.IOnItemSelectedListener
    {
        TextView selection;
        string[] items = {
            "this", "is", "a", "really", "really2", "really3",
            "really4", "really5", "silly", "list" };
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            selection = FindViewById<TextView>(Resource.Id.selection);
            Spinner sp = FindViewById<Spinner>(Resource.Id.spinner1);
            //create adapter 
            ArrayAdapter<string> aa = new ArrayAdapter<string>(
                this,
                Android.Resource.Layout.SimpleListItem1,
                items);
            //bind gridview to adapter
            sp.Adapter = aa;
            //listener 
            sp.OnItemSelectedListener = this;
        }

        private void On_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            selection.Text = items[e.Position];
            //throw new System.NotImplementedException();
        }

        public void OnItemSelected(AdapterView parent, View view, int position, long id)
        {
            selection.Text = items[position];
        }

        public void OnNothingSelected(AdapterView parent)
        {
            selection.Text = "";
        }
    }
}

