using ObjectOrientedPractics.Services;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Хранит полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart { get; set; }

        /// <summary>
        /// Возвращает и задает список заказов.
        /// </summary>
        public ObservableCollection<Order> Orders { get; set; }

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
        /// Возвращает и задает адрес доставки покупателя.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задает список скидок.
        /// </summary>
        public ObservableCollection<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Возвращает и задает является ли заказ приоритетным.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            Id = IdGenerator.GetNextId();
            FullName = "Customer";
            Address = new Address();
            Cart = new Cart();
            Orders = new ObservableCollection<Order>();
            IsPriority= false;
            Discounts = new ObservableCollection<IDiscount> { new PointsDiscount() };
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Не больше 200 символов.</param>
        /// <param name="address">Адрес доставки покупателя. Не больше 500 символов.</param>
        public Customer(string fullname, Address address)
        {
            Id = IdGenerator.GetNextId();
            FullName = fullname;
            Address = address;
            Cart = new Cart();
            Orders = new ObservableCollection<Order>();
            IsPriority = false;
            Discounts = new ObservableCollection<IDiscount>{ new PointsDiscount() };
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
        public Customer(string fullname, Address address, Cart cart, 
            ObservableCollection<Order> order, int id, bool isPriority, 
            ObservableCollection<IDiscount> discounts)
        {
            Id = id;
            FullName = fullname;
            Address = address;
            Cart = cart;
            Orders = order;
            IsPriority = isPriority;
            Discounts = discounts;
        }
    }
}
