using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Хранит список всех покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Хранит данные выбранного покупателя.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список покупателей класса <see cref="Customer"/>.
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
        /// Создает экземпляр 
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
            }
            else
            {
                FullNameTextBox.ReadOnly = false;
                AddressControl.Enabled = true;
            }
        }


        private void CustomersTab_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].FullName == "")
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
                AddressControl.UpdateTextBox();
                CheckListCount();
            }
            catch
            {
                if (_customers.Count == 0)
                {
                    AddressControl.ClearTextBox();
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
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = CustomerFactory.Randomize();
            CustomersListBox.Items.Add($"{_currentCustomer.FullName}");
            AddCustomer();
            CheckListCount();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.FullName = FullNameTextBox.Text;
                ToolTip.SetToolTip(FullNameTextBox, "");
                FullNameTextBox.BackColor = AppColors.CorrectColor;
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
    }
}
