using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создает экземпляр <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           ProjectSerializer.SaveItems(ItemsTab._items);
           ProjectSerializer.SaveCustomers(CustomersTab._customers);
        }
    }
}
