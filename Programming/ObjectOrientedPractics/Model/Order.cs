using System;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        private readonly DateTime _orderDate = DateTime.Now;

        private Address _address;

        private List<Item> _items;

        private double _amount = 0.0;

        private OrderStatus _orderStatus;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return _orderDate;
            }
        }

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

        public string FullName { get; set; }

        public Order()
        {
            _id = IdGenerator.GetNextId();
            Items = new List<Item>();
            Address = new Address();
        }

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
