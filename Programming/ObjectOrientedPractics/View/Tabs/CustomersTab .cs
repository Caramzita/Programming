using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();

        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
            CheckListCount();
        }

        private void ClearInfo()
        {
            IdTextBox.Clear();
            AddressTextBox.Clear();
            FullnameTextBox.Clear();
        }

        private void MakeCustomer()
        {  
            _customers.Add(_currentCustomer);
            CustomersListBox.SelectedIndex = _customers.Count - 1;
        }

        private void CheckListCount()
        {
            if (_customers.Count == 0)
            {
                FullnameTextBox.ReadOnly = true;
                AddressTextBox.ReadOnly = true;
            }
            else
            {
                FullnameTextBox.ReadOnly = false;
                AddressTextBox.ReadOnly = false;
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullnameTextBox.Text = _currentCustomer.Fullname;
                AddressTextBox.Text = _currentCustomer.Address;
            }
            catch
            {
                ClearInfo();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            CustomersListBox.Items.Add($"Customer {_currentCustomer.Id}");
            MakeCustomer();
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
            CustomersListBox.Items.Add($"{_currentCustomer.Fullname}");
            MakeCustomer();
            CheckListCount();
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = FullnameTextBox.Text;
                ToolTip.SetToolTip(FullnameTextBox, "");
                FullnameTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                FullnameTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(FullnameTextBox, exception.Message);
                return;
            }
        }

        private void FullnameTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int index = CustomersListBox.SelectedIndex;
                string changedFullname = FullnameTextBox.Text;
                CustomersListBox.Items.RemoveAt(index);
                CustomersListBox.Items.Insert(index, $"{changedFullname}");
                FullnameTextBox.Text = changedFullname;
                CustomersListBox.SelectedIndex = index;
            }
            catch 
            {
                ClearInfo();
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Address = AddressTextBox.Text;
                ToolTip.SetToolTip(AddressTextBox, "");
                AddressTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                AddressTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(AddressTextBox, exception.Message);
                return;
            }
        }
    }
}
