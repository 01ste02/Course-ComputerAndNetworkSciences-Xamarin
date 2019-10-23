using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Content.Res;

namespace MediaControllers
{
    [Activity(Label = "MediaControllers", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            ImageButton ib;
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            ib = FindViewById<ImageButton>(Resource.Id.imageButton1);
            ib.SetImageResource(Resource.Drawable.Icon);
            
            InitScrollview();
        }

        private void InitScrollview()
        {
            LinearLayout mGallery = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            string[] movieNames = Resources.GetStringArray(Resource.Array.movieNames);
            for (int pos = 0; pos < 15; pos++)
            { 
                View view = LayoutInflater.From(this).Inflate(Resource.Layout.layoutItem, mGallery, false);

                TextView text = view.FindViewById<TextView>(Resource.Id.movieDesc);
                text.Text = movieNames[pos + 1]; 

                ImageView i = view.FindViewById<ImageView>(Resource.Id.movieImage);
                i.SetImageResource(Resources.GetIdentifier("film" + (pos + 1), "drawable", PackageName));
                mGallery.AddView(view);
            }
        }
    }
}

