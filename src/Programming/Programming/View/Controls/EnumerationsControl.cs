using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
            string[] enums = { "Color", "EducationForm", "Genre", "Manufactures",
                "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
            ValuesListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = Enum.GetValues(typeof(Colors));
            switch (EnumsListBox.SelectedItem)
            {
                case "Color":
                    item = Enum.GetValues(typeof(Colors));
                    break;
                case "EducationForm":
                    item = Enum.GetValues(typeof(EducationForm));
                    break;
                case "Genre":
                    item = Enum.GetValues(typeof(Genre));
                    break;
                case "Manufactures":
                    item = Enum.GetValues(typeof(Manufactures));
                    break;
                case "Season":
                    item = Enum.GetValues(typeof(Season));
                    break;
                case "Weekday":
                    item = Enum.GetValues(typeof(WeekDay));
                    break;
            }
            ValuesListBox.Items.Clear();
            foreach (var value in item)
            {
                ValuesListBox.Items.Add(value);
            }
            ValuesListBox.SelectedIndex = 0;
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
            }
            catch { }
        }
    }
}
