using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Хранит полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Хранит адресс доставки покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Должно быть не больше 200 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адресс доставки покупателя.
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
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            FullName = "";
            Address = new Address();
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Не больше 200 символов.</param>
        /// <param name="address">Адресс доставки покупателя. Не больше 500 символов.</param>
        public Customer(string fullname, Address address)
        {
            FullName = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }
    }
}
