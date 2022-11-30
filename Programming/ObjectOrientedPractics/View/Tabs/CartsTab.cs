using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Item> _items;

        private List<Customer> _customers;

        private Cart _selectedCustomerCart;

        private Customer _selectedCustomer;

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

        void UpdateAmount(Cart cart)
        {
            Amount.Text = null;
            Amount.Text = _selectedCustomerCart.Amount.ToString();
        }

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

        public void RefreshData()
        {
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
        }

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

            CheckSelectedCustomer();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();

            _selectedCustomerCart = _customers[CustomersComboBox.SelectedIndex].Cart;

            _selectedCustomer = _customers[CustomersComboBox.SelectedIndex];

            int count = _customers[CustomersComboBox.SelectedIndex].Cart.Items.Count;

            for (int i = 0; i < count; i++)
            {
                CartListBox.Items.Add($"{_selectedCustomerCart.Items[i].Name}");
            }

            UpdateAmount(_selectedCustomerCart);
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
            UpdateAmount(_selectedCustomerCart);
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

            UpdateAmount(_selectedCustomerCart);
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if(_selectedCustomerCart.Items == null)
            {
                return;
            }

            CartListBox.Items.Clear();
            _selectedCustomerCart.Items.Clear();
            Amount.Text = "";
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order(_selectedCustomerCart.Items, _selectedCustomer.Address);
            _selectedCustomer.Orders.Add(order);
            CartListBox.Items.Clear();
        }

        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
