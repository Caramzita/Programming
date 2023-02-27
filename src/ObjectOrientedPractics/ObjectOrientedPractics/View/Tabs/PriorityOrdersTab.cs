using ObjectOrientedPractics.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит информацию о приоритетных заказах.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Создает случайного покупателя.
        /// </summary>
        private Customer _customer = CustomerFactory.Randomize();

        /// <summary>
        /// Хранит данные о приоритетном заказе.
        /// </summary>
        private PriorityOrder _priorityOrder;

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            _priorityOrder = new PriorityOrder(_customer.Cart.Items, _customer.Address, _customer.FullName,
                DateTime.Now, PriorityOrder.TimeIntervals[0]);

            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }

            foreach (string interval in PriorityOrder.TimeIntervals)
            {
                DeliveryTimeComboBox.Items.Add(interval);
            }

            IdTextBox.Text = _customer.Id.ToString();
            CreatedTextBox.Text = DateTime.Now.ToString();
            AddressControl.Address = _priorityOrder.Address;
            AddressControl.UpdateTextBox();     
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.Randomize();

            OrderItemsListBox.Items.Add($"{item.Name}");
            _priorityOrder.Items.Add(item);
            OrderItemsListBox.SelectedIndex = OrderItemsListBox.Items.Count - 1;
            Amount.Text = _customer.Cart.Amount.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = OrderItemsListBox.SelectedIndex;

            try
            {
                _priorityOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
                OrderItemsListBox.Items.RemoveAt(OrderItemsListBox.SelectedIndex);

                if (OrderItemsListBox.Items.Count > 0 && index != 0)
                {
                    OrderItemsListBox.SelectedIndex = index - 1;
                }
                else
                {
                    OrderItemsListBox.SelectedIndex = index;
                }

                Amount.Text = _customer.Cart.Amount.ToString();  
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

            if (_priorityOrder.Items.Count == 0)
            {
                Amount.Text = "0";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Amount.Text = "0";
            _customer.Cart.Items = new ObservableCollection<Item>();
            _priorityOrder.Items = _customer.Cart.Items;
            OrderItemsListBox.Items.Clear();
        }
    }
}
