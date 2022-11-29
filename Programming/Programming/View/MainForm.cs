using Programming.Model.Enums;
using Programming.Model.Classes;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SeasonHandleControl.SeasonChanged += SeasonHandleControl_SeasonChanged;
        }

        private void SeasonHandleControl_SeasonChanged(object sender, System.EventArgs e)
        {
            switch (SeasonHandleControl.CurrentSeason)
            {
                case Season.Summer:
                    MessageBox.Show("Урраа! Солнце!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                    break;
                case Season.Autumn:
                    this.BackColor = AppColors.AutumnColor;
                    break;
                case Season.Spring:
                    this.BackColor = AppColors.SpringColor;
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр!, холодно!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                    break;
            }
        }
    }
}
