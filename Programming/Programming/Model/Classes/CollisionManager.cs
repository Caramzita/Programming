using System;

namespace Programming.Model.Classes
{
    public class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dx = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double dy = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double halfSumLength = (rectangle1.Length - rectangle2.Length) / 2;
            double halfSumWidth = (rectangle1.Width - rectangle2.Width) / 2;

            if (dx < halfSumLength && dy < halfSumWidth)
            {
                return true;
            }

            return false;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dy = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double C = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

            if (C < (ring1.OuterRadius + ring2.OuterRadius))
            {
                return true;
            }

            return false;
        }
    }
}
