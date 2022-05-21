using System;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о круге: внутренний радиус, внешний радиус, координаты центра.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Хранит данные о внешнем радиусе.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Хранит данные о внутреннем радиусе.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Ring"/>.
        /// </summary>
        public Ring()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус. Должен быть больше внешнего радиуса.</param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть больше 0 и меньше внешнего радиуса.</param>
        /// <param name="center"></param>
        public Ring(double outerRadius, 
            double innerRadius,
            Point2D center)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Center = center;
        }

        /// <summary>
        /// Возвращает и задает внешний радиус. Должен быть больше внешнего радиуса.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
                Validator.AssertValueInRange(value, (int)InnerRadius, Int32.MaxValue ,nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен быть положительным и меньше внешнего радиуса.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
                Validator.AssertValueInRange(value, 0, (int)OuterRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает площать круга.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(_outerRadius, 2) - Math.Pow(_innerRadius, 2));
            }
        }

        /// <summary>
        /// Возвращает и задает центр круга класса <see cref="Ring"/>.
        /// </summary>
        public Point2D Center { get; set; }
    }
}
