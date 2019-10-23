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
    public class MovingPicture
    {
        int y, vy, x, vx, nrJumpY, nrJumpX;
        public int Y { get => y; set => y = value; }
        public int Vy { get => vy; set => vy = value; }
        public int X { get => x; set => x = value; }
        public int Vx { get => vx; set => vx = value; }
        public int NrJumpY { get => nrJumpY; set => nrJumpY = value; }
        public int NrJumpX { get => nrJumpX; set => nrJumpX = value; }

        public MovingPicture (int y, int vy, int x, int vx)
        {
            Y = y;
            Vy = vy;
            X = x;
            Vx = vx;
        }

        public void Update (int height, int width)
        {
            if (y < 0)
            {
                nrJumpY++;
                vy = -vy;
            }

            if (y > (height - 80))
            {
                vy = -vy;
            }
                y += vy;

            if (x < 0)
            {
                nrJumpX++;
                vx = -vx;
            }

            if (x > (width - 80))
            {
                vx = -vx;
            }
                x += vx;
        }
    }
}