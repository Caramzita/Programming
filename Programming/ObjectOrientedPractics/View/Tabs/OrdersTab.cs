using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers;

        private List<Order> _orders = new List<Order>();

        private Order _currentOrder;

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

        public void RefreshData()
        {
            _orders.Clear();

            for (int i = 0; i < _customers.Count; i++)
            {
                for (int j = 0; j < _customers[i].Orders.Count; j++)
                {
                    _orders.Add(_customers[i].Orders[j]);
                }
            }

            UpdateOrders();
        }

        private void UpdateOrders()
        {
            DataGridView.Rows.Clear();
            IdTextBox.Clear();
            CreatedTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;
            AddressControl.ClearAllTextBox();
            OrderItemsListBox.Items.Clear();
            Amount.Text = "0.0";

            for (int i = 0; i < _orders.Count; i++)
            {
                IdTextBox.Text = _orders[i].Id.ToString();
                CreatedTextBox.Text = _orders[i].OrderDate.ToString();
                StatusComboBox.SelectedItem = (OrderStatus)_orders[i].OrderStatus;
                AddressControl.Address = _orders[i].Address;
                Amount.Text = _orders[i].Amount.ToString();

                for (int j = 0; j < _orders[i].Items.Count; j++)
                {
                    if (_orders[i].Items[j].Name == "")
                    {
                        OrderItemsListBox.Items.Add($"Item {_orders[i].Items[j].Id}");
                        continue;
                    }

                    OrderItemsListBox.Items.Add($"{_orders[i].Items[j].Name}");
                }
            }

            for (int i = 0; i < _orders.Count; i++)
            {
                DataGridView.Rows.Add();
                DataGridView.Rows[i].Cells["ID"].Value = _orders[i].Id;
                DataGridView.Rows[i].Cells["Created"].Value = _orders[i].OrderDate;
                DataGridView.Rows[i].Cells["OrderStatusColumn"].Value = _orders[i].OrderStatus;
                DataGridView.Rows[i].Cells["FullName"].Value = _orders[i].FullName;
            }
        }

        public OrdersTab()
        {
            InitializeComponent();
        }

        private void OrdersTab_Load(object sender, EventArgs e)
        {
            if(_customers == null)
            {
                return;
            }

            for (int i = 0; i < _customers.Count; i++)
            {
                for (int j = 0; j < _customers[i].Orders.Count; j++)
                {
                    _orders.Add(_customers[i].Orders[j]);
                }
            }

            for (int i = 0; i < _orders.Count; i++)
            {
                DataGridView.Rows.Add();
                DataGridView.Rows[i].Cells["ID"].Value = _orders[i].Id;
                DataGridView.Rows[i].Cells["Created"].Value = _orders[i].OrderDate;
                DataGridView.Rows[i].Cells["OrderStatusColumn"].Value = _orders[i].OrderStatus;
                DataGridView.Rows[i].Cells["FullName"].Value = _orders[i].FullName;
            }

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }

            StatusComboBox.Enabled = false;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridView.CurrentRow == null)
            {
                return;
            }

            StatusComboBox.Enabled = true;

            OrderItemsListBox.Items.Clear();
            _currentOrder = _orders[DataGridView.CurrentRow.Index];
            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedTextBox.Text = _currentOrder.OrderDate.ToString();
            StatusComboBox.SelectedItem = (OrderStatus)_currentOrder.OrderStatus;
            AddressControl.Address = _currentOrder.Address;
            AddressControl.UpdateTextBox();

            for (int i = 0; i < _currentOrder.Items.Count; i++)
            {
                if (_currentOrder.Items[i].Name == "") 
                {
                    OrderItemsListBox.Items.Add($"Item {_currentOrder.Items[i].Id}");
                    continue;
                }

                OrderItemsListBox.Items.Add($"{_currentOrder.Items[i].Name}");
            }

            Amount.Text = _currentOrder.Amount.ToString();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DataGridView.CurrentRow == null)
            {
                return;
            }
            DataGridView.Rows[DataGridView.CurrentRow.Index].Cells["OrderStatusColumn"].Value = StatusComboBox.SelectedItem;
            _currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }
    }
}
