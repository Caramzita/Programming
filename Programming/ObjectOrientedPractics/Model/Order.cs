using System;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id = IdGenerator.GetNextId();

        private DateTime _orderDate = DateTime.Now;

        private Address _address;

        private List<Item> _items;

        private double _amount = 0.0;

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
                _orderDate = DateTime.Now;
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
                for (int i = 0; i < _items.Count; i++)
                {
                    _amount += _items[i].Cost;
                }

                return _amount;
            }
        }

        public Order()
        {

        }

        public Order(List<Item> items, Address address)
        {
            Items = items;
            Address = address;
        }
    }
}
