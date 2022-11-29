﻿using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные адресса.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Хранит почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Хранит страну покупателя.
        /// </summary>
        private string _country;

        /// <summary>
        /// Хранит город покупателя.
        /// </summary>
        private string _city;

        /// <summary>
        /// Хранит улицу покупателя.
        /// </summary>
        private string _street;

        /// <summary>
        /// Хранит строение покупателя.
        /// </summary>
        private string _building;

        /// <summary>
        /// Хранит номер квартиры покупателя.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс покупателя.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertIntOnLength(value, 99999, 1000000, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну проживания покупателя.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город покупателя.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу покупателя.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает строение покупателя.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры покупателя.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">почтовый индекс покупателя.</param>
        /// <param name="country">страна проживания.</param>
        /// <param name="city">город покупателя.</param>
        /// <param name="street">улица покупателя.</param>
        /// <param name="building">строение покупателя.</param>
        /// <param name="apartment">номер квартиры покупателя.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
