using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные адресса.
    /// </summary>
    public class Address : ICloneable
    {
        public event EventHandler<EventArgs> AddressChanged;

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

                if(_index != value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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

                if (_country != value)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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

                if (_city != value)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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

                if (_street != value)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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

                if (_building != value)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
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

                if (_apartment  != value)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            if (!(other is Address))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            Address address = (Address)other;

            return (this.Street == address.Street && this.City == address.City && this.Apartment == address.Apartment);

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

        /// <summary>
        /// Создает клон.
        /// </summary>
        /// <returns>Возвращает клон объекта.</returns>
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }
    }
}
