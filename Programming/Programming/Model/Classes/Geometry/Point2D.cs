using System;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о точке.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Хранит координату по X.
        /// </summary>
        private int _x;

        /// <summary>
        /// Хранит координату по Y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительной.</param>
        /// <param name="y">Координата Y. Должна быть положительной.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задает координату X. Должна быть положительной.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату Y. Должна быть положительной.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Y));
                _y = value;
            }
        }
    }
}
