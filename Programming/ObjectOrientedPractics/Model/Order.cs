using System;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;
using Newtonsoft.Json;

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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        /// <param name="address"></param>
        /// <param name="fullName"></param>
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
