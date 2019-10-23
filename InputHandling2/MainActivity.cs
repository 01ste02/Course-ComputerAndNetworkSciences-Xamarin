using Android.App;
using Android.Widget;
using Android.OS;
using static Android.Widget.CompoundButton;
using Android.Views;
using Android.Graphics;
using System;

namespace InputHandling2
{
    [Activity(Label = "InputHandling2", MainLauncher = true)]
    public class MainActivity : Activity, IOnCheckedChangeListener, RadioGroup.IOnCheckedChangeListener
    {
        TextView tw;
        RadioButton rb;
        RadioGroup rg;
        Switch sw;
        ToggleButton btn;
        CheckBox cb;

        public void OnCheckedChanged(RadioGroup group, int checkedId)
        {
            if (checkedId == Resource.Id.radioButton2)
            {
                tw.Text = "English";
            }
            else if (checkedId == Resource.Id.radioButton3)
            {
                tw.Text = "French";
            }
            else if (checkedId == Resource.Id.radioButton4)
            {
                tw.Text = "Swedish";
            }
        }

        public void OnCheckedChanged(CompoundButton buttonView, bool isChecked)
        {
            if(buttonView.Id == rb.Id)
            {
                Toast.MakeText(this, "Radio button says 'Fuck OFF'", ToastLength.Long).Show();
            }
            else if (buttonView.Id == cb.Id)
            {
                if (isChecked)
                {
                    Toast.MakeText(this, "Checkbox says 'I am turned ON, fuckers!'", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "Checkbox says 'I am turned OFF, you motherfuckers!'", ToastLength.Long).Show();
                }
            }
            else if (buttonView.Id == sw.Id)
            {
                if (isChecked)
                {
                    Toast.MakeText(this, "Switch says 'I am turned ON, fuckers!'", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "Switch says 'I am turned OFF, you motherfuckers!'", ToastLength.Long).Show();
                }
            }
            else if (buttonView.Id == btn.Id)
            {
                if (isChecked)
                {
                    btn.Text = "ON";
                    Toast.MakeText(this, "Togglebutton says 'I am turned ON, fuckers!'", ToastLength.Long).Show();
                }
                else
                {
                    Toast.MakeText(this, "Togglebutton says 'I am turned OFF, you motherfuckers!'", ToastLength.Long).Show();
                    btn.Text = "OFF";
                }
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            cb = FindViewById<CheckBox>(Resource.Id.checkBox1);
            rb = FindViewById<RadioButton>(Resource.Id.radioButton1);
            rg = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            tw = FindViewById<TextView>(Resource.Id.textView1);
            sw = FindViewById<Switch>(Resource.Id.switch1);
            btn = FindViewById<ToggleButton>(Resource.Id.toggleButton1);

            rb.SetOnCheckedChangeListener(this);
            cb.SetOnCheckedChangeListener(this);
            sw.SetOnCheckedChangeListener(this);
            btn.SetOnCheckedChangeListener(this);

            rg.SetOnCheckedChangeListener(this);
        }
    }
}

