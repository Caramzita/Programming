using System;
using System.Collections.ObjectModel;
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

        public event EventHandler<EventArgs> OrderCreated;

        /// <summary>
        /// Хранит список всех предметов.
        /// </summary>
        private ObservableCollection<Item> _items;

        /// <summary>
        /// Хранит список всех покупателей.
        /// </summary>
        private ObservableCollection<Customer> _customers;

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
            CustomersComboBox.Items.Clear();
            ItemsListBox.Items.Clear();
            DiscountsCheckedListBox.Items.Clear();

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

            if (_selectedCustomer != null)
            {
                for (int i = 0; i < _selectedCustomer.Discounts.Count; i++)
                {
                    DiscountsCheckedListBox.Items.Add(_selectedCustomer.Discounts[i].Info, true);
                }
            }

            CustomersComboBox.SelectedIndex = -1;

            if (_selectedCustomer != null)
            {
                Amount.Text = _selectedCustomer.Cart.Amount.ToString();
                UpdateDiscounts(_selectedCustomer);
            }
        }
        
        /// <summary>
        /// Вычисляет итоговую стоимость с учетом скидки.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        private double CalculateTotalDiscount(Customer customer)
        {
            double totalDiscount = 0;

            for(int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    totalDiscount += customer.Discounts[i].Calculate(customer.Cart.Items);
                }
            }

            return totalDiscount;
        }

        /// <summary>
        /// Обновляет данные отображения в Label.
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateDiscounts(Customer customer)
        {
            DiscountAmount.Text = CalculateTotalDiscount(customer).ToString();
            Total.Text = (customer.Cart.Amount - CalculateTotalDiscount(customer)).ToString();
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

            ItemsListBox.Items.Clear();
            CustomersComboBox.Items.Clear();

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

            CheckSelectedCustomer();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();
            DiscountsCheckedListBox.Items.Clear();

            if(CustomersComboBox.SelectedIndex == -1) 
            {
                return;
            }

            _selectedCustomerCart = _customers[CustomersComboBox.SelectedIndex].Cart;

            _selectedCustomer = _customers[CustomersComboBox.SelectedIndex];

            for (int i = 0; i < _selectedCustomerCart.Items.Count; i++)
            {
                if (_selectedCustomerCart.Items[i].Name == "")
                {
                    CartListBox.Items.Add($"Item {_selectedCustomerCart.Items[i].Id}");
                    continue;
                }

                CartListBox.Items.Add($"{_selectedCustomerCart.Items[i].Name}");
            }          

            for(int i = 0; i < _selectedCustomer.Discounts.Count; i++)
            {
                DiscountsCheckedListBox.Items.Add(_selectedCustomer.Discounts[i].Info, true);
            }

            UpdateDiscounts(_selectedCustomer);
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

            UpdateDiscounts(_selectedCustomer);
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

            UpdateDiscounts(_selectedCustomer);
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
            Order order;

            if (_selectedCustomer.IsPriority)
            {
                order = new PriorityOrder(_selectedCustomerCart.Items, _selectedCustomer.Address, 
                    _selectedCustomer.FullName, DateTime.Now.AddDays(5), PriorityOrder.TimeIntervals[0]);
            }
            else
            {
                order = new Order(_selectedCustomerCart.Items, _selectedCustomer.Address, _selectedCustomer.FullName);
            }

            order.DiscountAmount = CalculateTotalDiscount(_selectedCustomer);
            _selectedCustomer.Orders.Add(order);

            for(int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    _selectedCustomer.Discounts[i].Apply(_selectedCustomer.Cart.Items);
                }

                _selectedCustomer.Discounts[i].Update(_selectedCustomer.Cart.Items);
            }

            _selectedCustomerCart.Items = new ObservableCollection<Item>();
            CartListBox.Items.Clear();
            DiscountsCheckedListBox.Items.Clear();

            for (int i = 0; i < _selectedCustomer.Discounts.Count; i++)
            {
                DiscountsCheckedListBox.Items.Add(_selectedCustomer.Discounts[i].Info, true);
            }

            Amount.Text = "0.0";
            OrderCreated?.Invoke(this, EventArgs.Empty);
        }

        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                UpdateDiscounts(_selectedCustomer);
            }));     
        }
    }
}
