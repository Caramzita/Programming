using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о накопительной скидке.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable
    {
        /// <summary>
        /// Хранит количество накопленных баллов.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задает накопленные баллы. Задает только при инициализации.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество баллов должно быть положительным");
                }

                _points = value;
            }
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {_points} баллов";
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount() { }

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="points">Баллы.</param>
        [JsonConstructor]
        public PointsDiscount(int points)
        {
            Points = points;
        }

        /// <summary>
        /// Рассчитывает размер скидки.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(ObservableCollection<Item> items)
        {
            var totalAmount = 0.0;

            for (int i = 0; i < items.Count; i++)
            {
                totalAmount += items[i].Cost;
            }

            var discount = totalAmount * 0.3;

            if (_points < (int)(discount))
            {
                return _points;
            }
            else
            {
                return Math.Round(discount, 2);
            }
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(ObservableCollection<Item> items)
        {
            int totalDiscoint = (int)Calculate(items);
            _points -= totalDiscoint;

            return totalDiscoint;
        }

        /// <summary>
        /// Начисляет баллы за покупку.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        public void Update(ObservableCollection<Item> items)
        {
            var totalAmount = 0.0;

            for (int i = 0; i < items.Count; i++)
            {
                totalAmount += items[i].Cost;
            }

            _points += (int)Math.Round(totalAmount * 0.1);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            PointsDiscount otherPointDiscount = obj as PointsDiscount;

            if (otherPointDiscount != null)
            {
                return this.Points.CompareTo(otherPointDiscount.Points);
            }
            else
            {
                throw new ArgumentException("Объект не PointsDiscount");
            }
        }
    }
}
