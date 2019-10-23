using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace JumpingBall
{
    class MovingPicture
    {
        int y, vy, nrJump;
        public int Y { get => y; set => y = value; }
        public int Vy { get => vy; set => vy = value; }
        public int NrJump { get => nrJump; set => nrJump = value; }

        public MovingPicture (int y, int vy)
        {
            Y = y;
            Vy = vy;
        }

        public void Update (int height)
        {
            if (y < 0)
            {
                nrJump++;
                vy = -vy;
            }
            else if (y > height)
            {
                vy = -vy;
            }
            else
            {
                y += vy;
            }
        }
    }
}