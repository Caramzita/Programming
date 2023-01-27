using System;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Хранит дату создания заказа.
        /// </summary>
        private readonly DateTime _orderDate = DateTime.Now;

        /// <summary>
        /// Хранит адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Хранит список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит текущую цену товаров в заказе.
        /// </summary>
        private double _amount = 0.0;

        /// <summary>
        /// Хранит статус заказа.
        /// </summary>
        private OrderStatus _orderStatus;

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
        }

        /// <summary>
        /// Возвращает и задает 
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список предметов.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает итоговую цену товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                double amount = 0.0;

                for (int i = 0; i < _items.Count; i++)
                {
                    amount += _items[i].Cost;
                }

                _amount = amount;

                return _amount;
            }
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus
        {
            get
            {
                return _orderStatus;
            }
            set
            {
                _orderStatus = value;
            }
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="fullName">Полное имя покупателя.</param>
        public Order(List<Item> items, Address address, string fullName)
        {
            _id = IdGenerator.GetNextId();
            Items = items;
            Address = address;
            FullName = fullName;
            OrderStatus = OrderStatus.New;
        }
    }
}
