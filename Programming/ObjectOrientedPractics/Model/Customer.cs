using ObjectOrientedPractics.Services;
using System.Collections.Generic;
using Newtonsoft.Json;

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
        private readonly int _id = IdGenerator.GetNextId();

        /// <summary>
        /// Хранит полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Хранит адресс доставки покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Хранит корзину предметов покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Хранит список заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список заказов.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

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
            FullName = "Customer";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
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
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="cart">Корзина покупателя.</param>
        /// <param name="order">Заказ покупателя.</param>
        /// <param name="id">Уникальный идентификатор заказа.</param>
        [JsonConstructor]
        public Customer(string fullname, Address address, Cart cart, List<Order> order, int id)
        {
            _id = id;
            FullName = fullname;
            Address = address;
            Cart = cart;
            Orders = order;
        }
    }
}
