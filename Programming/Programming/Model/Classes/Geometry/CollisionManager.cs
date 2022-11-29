using System;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит методы по пересечению.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет на пересечение два прямоугольника.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если два прямоугольника пересекаются и false, если не пересекаются.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double halfSumLength = (rectangle1.Length + rectangle2.Length) / 2;
            double halfSumWidth = (rectangle1.Width + rectangle2.Width) / 2;
            double dx = Math.Abs((rectangle1.Center.X + rectangle1.Length / 2) - (rectangle2.Center.X + rectangle2.Length / 2));
            double dy = Math.Abs((rectangle1.Center.Y + rectangle1.Width / 2) - (rectangle2.Center.Y + rectangle2.Width / 2));
            return (dx < halfSumLength & dy < halfSumWidth);
        }

        /// <summary>
        /// Проверяет на пересечение два кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если два кольца пересекаются и false, если не пересекаются.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = Math.Abs(ring1.Center.X + ring2.Center.X);
            double dy = Math.Abs(ring1.Center.Y + ring2.Center.Y);
            double C = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));

            return C < (ring1.OuterRadius + ring2.OuterRadius);
        }
    }
}
