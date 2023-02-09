using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о накопительной скидке.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Хранит количество накопленных баллов.
        /// </summary>
        private int _points;

        /// <summary>
        /// Хранит скидку.
        /// </summary>
        private double _dicsount;

        /// <summary>
        /// Хранит итоговую сумму заказа.
        /// </summary>
        private double _totalAmount = 0;

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
        /// Считает размер скидки
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double totalAmount = 0;

            for (int i = 0; i < items.Count; i++)
            {
                totalAmount += items[i].Cost;
            }

            _totalAmount = totalAmount;

            _dicsount = totalAmount * 0.3;

            if (_points < (int)(_dicsount))
            {
                return _points;
            }
            else
            {
                return Math.Round(_dicsount);
            }
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            _points -= (int)Calculate(items);
            return _points;
        }

        /// <summary>
        /// Начисляет баллы за покупку.
        /// </summary>
        /// <param name="items"></param>
        public void Update(List<Item> items)
        {
            _points += (int)Math.Round(_totalAmount * 0.1);
        }   

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount() { }

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="points"></param>
        [JsonConstructor]
        public PointsDiscount(int points)
        {
            Points = points;
        }
    }
}
