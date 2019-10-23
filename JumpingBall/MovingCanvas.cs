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
    class MovingCanvas
    {
        MovingPicture b;
        Context c;

        public MovingPicture B { get => b; set => b = value; }

        public MovingCanvas(Context context, IAttributeSet attrs): base()
        {
            Initialize();
            c = context;
        }

        public MovingCanvas(Context context, IAttributeSet attrs, int defStyle):
            base()
        {
            Initialize();
            c = context;
        }

        private void Initialize()
        {

        }

        protected override void OnMeasure(int w, int h)
        {
            base.OnMeasure(w, h);
            this.SetMeasuredDimension(MeasureSpec.GetSize(w), MeasureSpec.GetSize(h));
            this.B = new MovingCanvas(Height / 2, 10);

        }

        protected override void OnDraw(Canvas canvas)
        {
            this.SetBackgroundColor(Color.White);
            Paint p = new Paint();
            canvas.DrawBitmap(BitmapFactory.DecodeResource(c.Resources, Resource.Drawable.ball), Width / 2, B.Y, p);
            FontMetrics fm = p.GetFontMetrics();
            p.Color = Color.Black;
            p.StrokeWidth = 2;
            p.TextSize = 24;
            canvas.DrawText(b.NrJump + " jumps", 10, Height / 2 - (fm.Ascent + fm.Descent) / 2, p);

        }

    }
}