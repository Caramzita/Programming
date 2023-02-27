using System;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Создает случайный прямоугольник класса <see cref="Rectangle"/>.
    /// </summary>
    static class RectangleFactory
    {
        /// <summary>
        /// Генерирует случайное значение.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Хранит массив названий цветов.
        /// </summary>
        private static string[] _colors = { "White", "Black", "Red", "Orange", "Green",
                "Blue", "Brown", "Yellow", "Grey", "Pink" };

        /// <summary>
        /// Создает случайный прямоугольник класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="maxWidth">Максимальная ширина границы создания прямоугольника.</param>
        /// <param name="maxHeight">Максимальная высота границы создания прямоугольника.</param>
        /// <returns>Возвращает прямоугольник класса <see cref="Rectangle"/>.</returns>
        public static Rectangle Randomize(int maxWidth, int maxHeight)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(1, 300);
            rectangle.Length = _random.Next(1, 300);
            rectangle.Color = _colors[_random.Next(_colors.Length)];
            rectangle.Center = new Point2D(_random.Next(1, maxWidth),
                _random.Next(1, maxHeight));
            return rectangle;
        }
    }
}
