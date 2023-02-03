using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    ///  Хранит данные о корзине покупателя.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Хранит список всех предметов.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит список всех покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Хранит корзину выбранного покупателя.
        /// </summary>
        private Cart _selectedCustomerCart;

        /// <summary>
        /// Хранит выбранного покупателя.
        /// </summary>
        private Customer _selectedCustomer;
        
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
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
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
        /// Обновляет цену товаров в корзине.
        /// </summary>
        void UpdateAmount()
        {
            Amount.Text = null;
            Amount.Text = _selectedCustomerCart.Amount.ToString();
        }

        /// <summary>
        /// Проверяет, если пользователь не выбран, то отключаются кнопки.
        /// </summary>
        void CheckSelectedCustomer()
        {
            if(_selectedCustomerCart == null)
            {
                AddButton.Enabled = false;
                RemoveItemButton.Enabled = false;
                ClearCartButton.Enabled = false;
                CreateOrderButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
                RemoveItemButton.Enabled = true;
                ClearCartButton.Enabled = true;
                CreateOrderButton.Enabled = true;
            }
        }

        /// <summary>
        /// Обновляет все данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            CustomersComboBox.SelectedIndex = -1;
            CustomersComboBox.Items.Clear();
            ItemsListBox.Items.Clear();

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == "")
                {
                    ItemsListBox.Items.Add($"Item {_items[i].Id}");
                    continue;
                }
                ItemsListBox.Items.Add($"{_items[i].Name}");
            }

            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].FullName == "Customer")
                {
                    CustomersComboBox.Items.Add($"Customer {_customers[i].Id}");
                    continue;
                }
                CustomersComboBox.Items.Add($"{_customers[i].FullName}");
            }

            CustomersComboBox.SelectedIndex = -1;

            if (_selectedCustomer != null)
            {
                Amount.Text = _selectedCustomer.Cart.Amount.ToString();
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        private void CartsTab_Load(object sender, EventArgs e)
        {
            if(_items == null)
            {
                return;
            }

            for(int i = 0; i < _items.Count; i++)
            {
                if(_items[i].Name == "")
                {
                    ItemsListBox.Items.Add($"Item {_items[i].Id}");
                    continue;
                }
                ItemsListBox.Items.Add($"{_items[i].Name}");
            }

            for(int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].FullName == "Customer")
                {
                    CustomersComboBox.Items.Add($"Customer {_customers[i].Id}");
                    continue;
                }
                CustomersComboBox.Items.Add($"{_customers[i].FullName}");
            }
            CustomersComboBox.SelectedIndex = -1;

            CheckSelectedCustomer();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();

            if(CustomersComboBox.SelectedIndex == -1) 
            {
                return;
            }

            _selectedCustomerCart = _customers[CustomersComboBox.SelectedIndex].Cart;

            _selectedCustomer = _customers[CustomersComboBox.SelectedIndex];

            int count = _customers[CustomersComboBox.SelectedIndex].Cart.Items.Count;

            for (int i = count - 1; i >= 0; i--)
            {
                if (!_items.Contains(_customers[CustomersComboBox.SelectedIndex].Cart.Items[i]))
                {
                    _selectedCustomerCart.Items.RemoveAt(i);
                }
            }

            for (int i = 0; i < _selectedCustomerCart.Items.Count; i++)
            {
                if (_selectedCustomerCart.Items[i].Name == "")
                {
                    CartListBox.Items.Add($"Item {_selectedCustomerCart.Items[i].Id}");
                    continue;
                }

                CartListBox.Items.Add($"{_selectedCustomerCart.Items[i].Name}");
            }

            UpdateAmount();
            CheckSelectedCustomer();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedCustomerCart.Items.Add(_items[ItemsListBox.SelectedIndex]);
            if(_items[ItemsListBox.SelectedIndex].Name == "")
            {
                CartListBox.Items.Add($"Item {_items[ItemsListBox.SelectedIndex].Id}");
            }
            else
            {
                CartListBox.Items.Add($"{_items[ItemsListBox.SelectedIndex].Name}");
            }
            UpdateAmount();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if(_selectedCustomerCart.Items.Count == 0 && CartListBox.SelectedIndex == 0)
            {
                return;
            }

            int currentIndex = CartListBox.SelectedIndex;

            if (currentIndex >= 0 && _selectedCustomerCart.Items.Count != 0)
            {
                _selectedCustomerCart.Items.RemoveAt(currentIndex);
                if (CartListBox.SelectedIndex == 0 && _selectedCustomerCart.Items.Count >= 1)
                {
                    CartListBox.SelectedIndex = currentIndex + 1;
                }
                else
                {
                    CartListBox.SelectedIndex = currentIndex - 1;
                }
                CartListBox.Items.RemoveAt(currentIndex);
            }

            UpdateAmount();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if(_selectedCustomerCart.Items == null)
            {
                return;
            }

            CartListBox.Items.Clear();
            _selectedCustomerCart.Items.Clear();
            Amount.Text = "0";
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer.IsPriority)
            {
                PriorityOrder order = new PriorityOrder(_selectedCustomerCart.Items, _selectedCustomer.Address, _selectedCustomer.FullName,
                    DateTime.Now.AddDays(5), PriorityOrder.TimeIntervals[0]);
                _selectedCustomer.Orders.Add(order);
            }
            else
            {
                Order order = new Order(_selectedCustomerCart.Items, _selectedCustomer.Address, _selectedCustomer.FullName);
                _selectedCustomer.Orders.Add(order);
            }

            _selectedCustomerCart.Items = new List<Item>();
            CartListBox.Items.Clear();
            Amount.Text = "0.0";
        }
    }
}
