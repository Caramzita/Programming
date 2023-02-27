using System;
using ObjectOrientedPractics.Services;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о заказе покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Хранит текущую цену товаров в заказе.
        /// </summary>
        private double _amount = 0.0;

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задает список предметов.
        /// </summary>
        public ObservableCollection<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает размер примененной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Возвращает итоговую цену товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0.0;

                for (int i = 0; i < Items.Count; i++)
                {
                    amount += Items[i].Cost;
                }

                _amount = amount;

                return _amount;
            }
        }

        /// <summary>
        /// Возвращает конечную стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="fullName">Полное имя покупателя.</param>
        public Order(ObservableCollection<Item> items, Address address, string fullName)
        {
            Id = IdGenerator.GetNextId();
            Items = items;
            Address = address;
            FullName = fullName;
            OrderStatus = OrderStatus.New;
            OrderDate = DateTime.Now;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="fullName">Полное имя покупателя.</param>
        /// <param name="orderDate">Дата создания заказа.</param>
        [JsonConstructor]
        public Order(ObservableCollection<Item> items, Address address, string fullName, DateTime orderDate)
        {
            Id = IdGenerator.GetNextId();
            Items = items;
            Address = address;
            FullName = fullName;
            OrderStatus = OrderStatus.New;
            OrderDate = orderDate;
        }
    }
}
