using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace JumpingBall
{
    public class MovingCanvas : View
    {
        MovingPicture b;
        Context c;

        public MovingPicture B { get => b; set => b = value; }

        public MovingCanvas(Context context, IAttributeSet attrs): base(context, attrs)
        {
            Initialize();
            c = context;
        }

        public MovingCanvas(Context context, IAttributeSet attrs, int defStyle):
            base(context, attrs, defStyle)
        {
            Initialize();
            c = context;
        }

        private void Initialize()
        {

        }

        protected override void OnMeasure (int w, int h)
        {
            base.OnMeasure
        }

    }
}