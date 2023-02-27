using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class SeasonHandleControl : UserControl
    {
        public event EventHandler SeasonChanged;

        public Season CurrentSeason { get; set; }

        public SeasonHandleControl()
        {
            InitializeComponent();
            SeasonComboBox.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(value);
            }
            SeasonComboBox.SelectedIndex = 0;
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            CurrentSeason = (Season)SeasonComboBox.SelectedItem;
            SeasonChanged?.Invoke(this, EventArgs.Empty);
;        }
    }
}
