using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        /// <summary>
        /// Создает экземпляр <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           //ProjectSerializer.SaveItems(ItemsTab._items);
           //ProjectSerializer.SaveCustomers(CustomersTab._customers);
        }
    }
}
