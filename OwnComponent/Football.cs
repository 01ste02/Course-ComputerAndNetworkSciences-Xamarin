using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Util;
using Android.Views;

namespace OwnComponent
{
    public class Football : View
    {
        public Football(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
        }

        protected override void OnMeasure(int w, int h)
        {
            base.OnMeasure(w, h);
            this.SetMeasuredDimension(MeasureSpec.GetSize(w), MeasureSpec.GetSize(h));
        }

        public Football(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize();
        }

        private void Initialize()
        {
        }

        protected override void OnDraw(Canvas c)
        {
            //skapa en ritningsverktyg	
            Paint p = new Paint();
            //bestämma pennans färg
            p.Color = Color.White;
            //bestämma pennas tjocklek
            p.StrokeWidth = 3;
            /*bestämma stilen FILL=ifyllda figurer, STROKE – icke ifyllda        figurer*/
            p.SetStyle(Paint.Style.Stroke);
            /*rita en linje som sträcker sig från  (15,15) till (getWidth()- 15,15)
        getWidth() hämtar komponentens bredd
        getHeight() hämtar komponentens höjd*/
            c.DrawLine(15, Height / 2, (float)(Width - 15), Height / 2, p);
            /*rita en cirkel med centrum i  (15,15)  och radie 20*/
            c.DrawCircle(Width / 2, Height / 2, 20, p);
            /*rita en rektangel med övre - vänstra hörnet i  (15,15)  och nedre-högra hörnet i (100,100)*/
            c.DrawRect(15, 15, Width - 15, Height - 15, p);
            /*rita en båge  - båge omsluts i rektangel  med  övre - vänstra hörnet i  (0,0)  och nedre - högra hörnet i (30,30) */
            RectF arcRect1 = new RectF(0, 0, 30, 30);
            RectF arcRect2 = new RectF(Width - 30, 0, Width, 30);
            RectF arcRect3 = new RectF(0, Height - 30, 30, Height);
            RectF arcRect4 = new RectF(Width - 30, Height - 30, Width, Height);
            /*båge som definierades i föregående satsen ritas – ritningen startar från 360 grader (medurs) och därefter ritas 90 grader i medurs riktning. Om true istället för false anges då ritas tårtbit istället – med style STROKE*/
            c.DrawArc(arcRect1, 360, 90, false, p);
            c.DrawArc(arcRect2, 90, 90, false, p);
            c.DrawArc(arcRect3, 270, 90, false, p);
            c.DrawArc(arcRect4, 180, 90, false, p);

            c.DrawRect((Width / 2) - 50, 15, (Width / 2) + 50, 45, p);
            RectF arcRect5 = new RectF((Width / 2) - 7, 39, (Width / 2) + 7, 53);
            c.DrawArc(arcRect5, 0, 180, false, p);

            c.DrawRect((Width / 2) - 50, Height - 45, (Width / 2) + 50, Height - 15, p);
            RectF arcRect6 = new RectF((Width / 2) - 7, Height - 53, (Width / 2) + 7, Height - 39);
            c.DrawArc(arcRect6, 180, 180, false, p);
        }
    }
}

