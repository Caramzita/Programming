using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Properties;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит данные о всех заказах покупателей.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Хранит список всех покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Хранит список всех заказов.
        /// </summary>
        private readonly List<Order> _orders = new List<Order>();

        /// <summary>
        /// Хранит данные о выбранном заказе.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Хранит данные о выбранном приоритетном заказе.
        /// </summary>
        private PriorityOrder _currentPriorityOrder;

        /// <summary>
        /// Возвращает и задает список всех покупателей.
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
        /// Возвращает и задает выбранный заказ. Проверяет на приоритетность.
        /// </summary>
        public Order CheckPriority
        {
            get
            {
                return _currentOrder;
            }
            set
            {
                if (_currentOrder is PriorityOrder)
                {
                    PriorityPanel.Visible = true;
                    _currentPriorityOrder = (PriorityOrder)value;
                    DeliveryTimeComboBox.SelectedItem = _currentPriorityOrder.DesiredTime;
                    DeliveryDatePicker.MinDate = DateTime.Now;
                    DeliveryDatePicker.Value = _currentPriorityOrder.DesiredDate;
                }
                else
                {
                    PriorityPanel.Visible = false;
                    _currentPriorityOrder = null;
                    _currentOrder = value;
                }
            }
        }

        /// <summary>
        /// Обновляет данные заказов.
        /// </summary>
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

        /// <summary>
        /// Обновляет данные в таблице заказов.
        /// </summary>
        private void UpdateOrders()
        {
            DataGridView.Rows.Clear();
            IdTextBox.Clear();
            CreatedTextBox.Clear();
            StatusComboBox.SelectedIndex = -1;
            OrderItemsListBox.Items.Clear();
            PriorityPanel.Visible = false;
            Amount.Text = "0.0";

            if(_orders.Count == 0)
            {
                AddressControl.ClearAllTextBox();
            }

            for (int i = 0; i < _orders.Count; i++)
            {
                DataGridView.Rows.Add();
                DataGridView.Rows[i].Cells["ID"].Value = _orders[i].Id;
                DataGridView.Rows[i].Cells["Created"].Value = _orders[i].OrderDate;
                DataGridView.Rows[i].Cells["OrderStatusColumn"].Value = _orders[i].OrderStatus;
                DataGridView.Rows[i].Cells["FullName"].Value = _orders[i].FullName;
                DataGridView.Rows[i].Cells["Address"].Value = $"{_orders[i].Address.Country}, {_orders[i].Address.City}, " +
                    $"{_orders[i].Address.Street}, {_orders[i].Address.Building}, " +
                    $"{_orders[i].Address.Apartment}, {_orders[i].Address.Index}";
                DataGridView.Rows[i].Cells["AmountColumn"].Value = _orders[i].Amount;
                DataGridView.Rows[i].Cells["TotalColumn"].Value = _orders[i].Total;

                if (_orders[i] is PriorityOrder)
                {
                    DataGridView.Rows[i].Cells["IsPriority"].Value = Resources.star;
                }
                else
                {
                    DataGridView.Rows[i].Cells["IsPriority"].Value = Resources.empty;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класс <see cref="OrdersTab"/>.
        /// </summary>
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

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }

            foreach(string interval in PriorityOrder.TimeIntervals)
            {
                DeliveryTimeComboBox.Items.Add(interval);
            }

            StatusComboBox.Enabled = false;       

            AddressControl.AddressIsReadOnly();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow == null)
            {
                return;
            }

            StatusComboBox.Enabled = true;

            OrderItemsListBox.Items.Clear();

            if(_orders.Count == 0)
            {
                return;
            }

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

            CheckPriority = _currentOrder;

            Total.Text = _currentOrder.Total.ToString();
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

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DesiredTime = DeliveryTimeComboBox.SelectedItem.ToString();
        }

        private void DeliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _currentPriorityOrder.DesiredDate = DeliveryDatePicker.Value;
        }
    }
}
