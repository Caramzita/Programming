using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Collections.ObjectModel;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит данные о всех покупателях.
    /// </summary>
    public partial class CustomersTab : UserControl
    {

        public event EventHandler<EventArgs> CustomersChanged;

        /// <summary>
        /// Хранит список всех покупателей.
        /// </summary>
        private ObservableCollection<Customer> _customers;

        /// <summary>
        /// Хранит данные выбранного покупателя.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список покупателей класса <see cref="Customer"/>.
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
        /// Создает экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            CheckListCount();
        }

        /// <summary>
        /// Очищает все поля.
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
        }

        /// <summary>
        /// Добавляет покупателя в список всех покупателей.
        /// </summary>
        private void AddCustomer()
        {
            _customers.Add(_currentCustomer);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        /// <summary>
        /// Проверяет <see cref="CustomersListBox"/>, если он пуст или элемент списка не выбран, то в поля нельзя вводить значения.
        /// </summary>
        private void CheckListCount()
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                FullNameTextBox.ReadOnly = true;
                AddressControl.Enabled = false;
                PriorityCheckBox.Enabled= false;
            }
            else
            {
                FullNameTextBox.ReadOnly = false;
                AddressControl.Enabled = true;
                PriorityCheckBox.Enabled = true;
            }
        }


        private void CustomersTab_Load(object sender, EventArgs e)
        {
            if(_customers == null)
            {
                return;
            }
            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].FullName == "Customer")
                {
                    CustomersListBox.Items.Add($"Customer {_customers[i].Id}");
                    continue;
                }
                CustomersListBox.Items.Add(_customers[i].FullName);
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressControl.Address = _currentCustomer.Address;
                PriorityCheckBox.Checked = _currentCustomer.IsPriority;
                AddressControl.UpdateTextBox();
                DiscountsListBox.Items.Clear();

                foreach (var discount in _currentCustomer.Discounts)
                {
                    DiscountsListBox.Items.Add(discount.Info);
                }

                CheckListCount();
            }
            catch
            {
                if (_customers.Count == 0)
                {
                    AddressControl.ClearAllTextBox();
                    ClearInfo();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            CustomersListBox.Items.Add($"Customer {_currentCustomer.Id}");
            AddCustomer();
            CheckListCount();
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int lastIndex = CustomersListBox.SelectedIndex;
            if (lastIndex >= 0 && _customers.Count != 0)
            {
                _customers.RemoveAt(lastIndex);
                if (CustomersListBox.SelectedIndex == 0 && _customers.Count >= 1)
                {
                    CustomersListBox.SelectedIndex = lastIndex + 1;
                }
                else
                {
                    CustomersListBox.SelectedIndex = lastIndex - 1;
                }
                CustomersListBox.Items.RemoveAt(lastIndex);
            }
            CheckListCount();
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = CustomerFactory.Randomize();
            CustomersListBox.Items.Add($"{_currentCustomer.FullName}");
            AddCustomer();
            CheckListCount();
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.FullName = FullNameTextBox.Text;
                ToolTip.SetToolTip(FullNameTextBox, "");
                FullNameTextBox.BackColor = AppColors.CorrectColor;
                CustomersChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(FullNameTextBox, exception.Message);
                return;
            }
        }

        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int index = CustomersListBox.SelectedIndex;
                string changedFullname = FullNameTextBox.Text;
                CustomersListBox.Items.RemoveAt(index);
                CustomersListBox.Items.Insert(index, $"{changedFullname}");
                FullNameTextBox.Text = changedFullname;
                CustomersListBox.SelectedIndex = index;
            }
            catch
            {
                ClearInfo();
            }
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer.IsPriority = PriorityCheckBox.Checked;
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            addDiscountForm.ShowDialog();

            if(addDiscountForm.DialogResult == DialogResult.OK)
            {
                _currentCustomer.Discounts.Add(new PercentDiscount(addDiscountForm.SelectedCategory));
                DiscountsListBox.Items.Add(_currentCustomer.Discounts[_currentCustomer.Discounts.Count - 1].Info);
            }

            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DiscountsListBox.SelectedIndex == 0)
                {
                    return;
                }

                _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
                DiscountsListBox.Items.RemoveAt(DiscountsListBox.SelectedIndex);
                CustomersChanged?.Invoke(this, EventArgs.Empty);
            }
            catch 
            {
                return; 
            };
        }
    }
}
