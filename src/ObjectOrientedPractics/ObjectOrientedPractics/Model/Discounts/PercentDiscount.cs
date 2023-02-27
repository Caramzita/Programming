using System;
using System.Collections.ObjectModel;
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
        /// Хранит текущую скидку от 0 до 1.
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
                return $"Процентная «{Category}» - {_currentDiscount * 100}%";
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товаров.
        /// </summary>
        public Category Category { get; private set; }

        /// <summary>
        /// Возвращает и задает текущую скидку.
        /// </summary>
        public double CurrentDiscount { get; private set; }

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

        /// <summary>
        /// Рассчитывает скидку для текущей корзины с данной категорией товаров.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <returns>Возвращает скидку на корзину.</returns>
        public double Calculate(ObservableCollection<Item> items)
        {
            double totalDiscount = 0;
            double spentMoney = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
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
        public double Apply(ObservableCollection<Item> items)
        {
            _currentDiscount = 0.01;
            return Calculate(items);
        }

        /// <summary>
        /// Начисляет проценты на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(ObservableCollection<Item> items)
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

        /// <inheritdoc />
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
    }
}
