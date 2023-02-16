using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;
using System.Collections.Specialized;
using System;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит данные класса <see cref="Store"/>.
        /// </summary>
        private readonly Store _store = ProjectSerializer.LoadDataFromFile();

        /// <summary>
        /// Создает экземпляр клааса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;      
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;     
        }

        private void ItemsTab_Changed(object sender, EventArgs e)
        {
            CartsTab.RefreshData();           
            OrdersTab.RefreshData();
        }

        private void CustomerTab_Changed(object sender, EventArgs e)
        {
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }

        private void OrderTab_CreatedOrder(object sender, EventArgs e)
        {
            OrdersTab.RefreshData();
        }

        public void Store_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    if (e.NewItems?[0] is Store)
                        CartsTab.RefreshData();
                        OrdersTab.RefreshData();
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    if (e.OldItems?[0] is Store)
                        CartsTab.RefreshData();
                        OrdersTab.RefreshData();
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    if ((e.NewItems?[0] is Store) &&
                        (e.OldItems?[0] is Store))
                        CartsTab.RefreshData();
                        OrdersTab.RefreshData();
                    break;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SaveData(_store);
        }
    }
}