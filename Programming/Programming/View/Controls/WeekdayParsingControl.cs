using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using System.Globalization;

namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            WeekDay weekDay;
            string parsingWeekDay = ParsingTextBox.Text;
            var textInfo = new CultureInfo("ru-RU").TextInfo;
            var capitalizedText = textInfo.ToTitleCase(textInfo.ToLower(parsingWeekDay));
            if (Enum.TryParse(parsingWeekDay, true, out weekDay))
            {
                ParsingLabelOut.Text = $"Этот день недели ({capitalizedText} = {(int)weekDay})";
            }
            else
            {
                ParsingLabelOut.Text = "Нет такого дня недели";
            }
            ParsingLabelOut.Visible = true;
        }
    }
}
