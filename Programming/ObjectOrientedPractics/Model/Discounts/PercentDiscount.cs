using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о процентной скидке.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable
    {
        /// <summary>
        /// Хранит категорию товара, на которую предоставляется скидка.
        /// </summary>
        private Category _discountCategory;

        /// <summary>
        /// Хранит текущаю скидку.
        /// </summary>
        private double _currentDiscount = 0.01;

        /// <summary>
        /// Хранит потраченные деньги на данную категорию товаров.
        /// </summary>
        private double _spentMoney = 0;

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{_discountCategory}» - {_currentDiscount * 100}%";
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товаров.
        /// </summary>
        public Category Category
        {
            get
            {
                return _discountCategory;
            }
            private set
            {
                _discountCategory = value;
            }
        }

        /// <summary>
        /// Возвращает и задает текущую скидку.
        /// </summary>
        public double CurrentDiscount
        {
            get
            {
                return _currentDiscount;
            }
            private set
            {
                _currentDiscount = value;
            }
        }

        /// <summary>
        /// Рассчитывает скидку для текущей корзины с данной категорией товаров.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Возвращает скидку на корзину.</returns>
        public double Calculate(List<Item> items)
        {
            double totalDiscount = 0;
            double spentMoney = 0;

            foreach (var item in items)
            {
                if (item.Category == _discountCategory)
                {
                    totalDiscount += item.Cost * _currentDiscount;
                    spentMoney += item.Cost * (1 - _currentDiscount);             
                }
            }

            _spentMoney = spentMoney;

            return totalDiscount;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Возвращает скидку со списанными баллами.</returns>
        public double Apply(List<Item> items)
        {
            _currentDiscount = 0.01;
            return Calculate(items);
        }

        /// <summary>
        /// Добавляет баллы на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            if((_spentMoney / 1000) > 10)
            {
                _currentDiscount = 0.1;
            }
            else
            {
                _currentDiscount = ((int)_spentMoney / 1000) * 0.01;
            }

            if(_currentDiscount == 0)
            {
                _currentDiscount = 0.01;
            }
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <param name="obj">Объект.</param>
        /// <returns>Возвращает число обозначающее сравнение</returns>
        /// <exception cref="ArgumentException">Объект не PercentDiscount</exception>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            PercentDiscount otherPercentDiscount = obj as PercentDiscount;

            if (otherPercentDiscount != null)
            {
                return this.CurrentDiscount.CompareTo(otherPercentDiscount.CurrentDiscount);
            }
            else
            {
                throw new ArgumentException("Объект не PercentDiscount");
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="discountCategory">Категория товаров.</param>
        public PercentDiscount(Category discountCategory) 
        {
            Category = discountCategory;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория товаров.</param>
        /// <param name="currentDiscount">Текущая скидка.</param>
        /// <param name="spentMoney">Потраченные деньги на данную категорию.</param>
        [JsonConstructor]
        public PercentDiscount(Category category,
            double currentDiscount, double spentMoney)
        {
            Category = category;
            CurrentDiscount = currentDiscount;
            _spentMoney = spentMoney;
        }
    }
}
