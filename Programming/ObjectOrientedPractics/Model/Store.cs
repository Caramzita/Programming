using System.Collections.ObjectModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные магазина.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Хранит список предметов класса <see cref="Item"/>.
        /// </summary>
        private ObservableCollection<Item> _items;

        /// <summary>
        /// Хранит список покупателей класса <see cref="Customer"/>.
        /// </summary>
        private ObservableCollection<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список предметов.
        /// </summary>
        public ObservableCollection<Item> Items
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
        /// Возвращает и задает список покупателей.
        /// </summary>
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new ObservableCollection<Item>();
            Customers = new ObservableCollection<Customer>();
        }
    }
}
