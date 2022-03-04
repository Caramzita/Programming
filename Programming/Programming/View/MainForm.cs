using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();           
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] enums = { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
            ParsingTextOut.Visible = false;
            SeasonComboBox.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(value);
            }
            SeasonComboBox.SelectedIndex = 0;

        }

        private void Enums_Click(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = Enum.GetValues(typeof(Model.Color));
            switch (EnumsListBox.SelectedItem)
            {
                case "Color":
                    item = Enum.GetValues(typeof(Model.Color));
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
                    item = Enum.GetValues(typeof(Weekday));
                    break; 
            }
            ValuesListBox.Items.Clear();
            foreach (var value in item)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int_value.Text = ((int)ValuesListBox.SelectedIndex + 1).ToString(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Weekday day;
            string str = ParsingTextbox.Text;
            if (Enum.TryParse(str, true, out day))
            {
                ParsingTextOut.Text = $"Этот день недели ({str} = {(int)day})";
            }
            else
            {
                ParsingTextOut.Text = "Нет такого дня недели";
            }
            ParsingTextOut.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ParsingTextOut_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SeasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            var type = (Season)SeasonComboBox.SelectedItem;
            switch (type)
            {
                case Season.Summer:
                    MessageBox.Show("Урраа! Солнце!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
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
