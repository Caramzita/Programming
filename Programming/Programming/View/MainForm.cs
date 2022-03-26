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
        private Model.Classes.Rectangle[] _rectangles;
        private Model.Classes.Film[] _films;
        private Model.Classes.Rectangle _currentRecrangle;
        private Model.Classes.Film _currentFilm;
        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] array)
        {
            var _currecntIndex = -1;
            double max = 0;
            for(int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > max)
                {
                    max = _rectangles[i].Width;
                    _currecntIndex = i;
                }
            }
            return _currecntIndex;
        }
        private int FindFilmWithMaxRating(Model.Classes.Film[] array)
        {
            var _currecntIndex = -1;
            double max = 0;
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i].Rating > max)
                {
                    max = _films[i].Rating;
                    _currecntIndex = i;
                }
            }
            return _currecntIndex;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] enums = { "Color", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            string[] colors = { "White", "Black", "Red", "Orange", "Green", "Blue", "Brown", "Yellow", "Grey", "Pink" };
            string[] filmsNames = { "The Dark Knight", "The Fly", "The Conjuring", "The Thing", "Blade", "Insidious" };
            string[] genres = { " Drama", "Comedy", "Musical", "Romance", "Romantic comedy" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
            SeasonComboBox.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(value);
            }
            SeasonComboBox.SelectedIndex = 0;
            _rectangles = new Model.Classes.Rectangle[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(random.Next(1, 100), random.Next(1, 100), colors[random.Next(colors.Length)]);
                RectanglesListBox.Items.Add($"Rectangle {i+1}");
            }
            RectanglesListBox.SelectedIndex = 0;
            _films = new Model.Classes.Film[6];
            for (int i = 0; i < 6; i++)
            {
                _films[i] = new Model.Classes.Film(filmsNames[random.Next(filmsNames.Length)], random.Next(60, 180), random.Next(2000,2022), genres[random.Next(genres.Length)], random.Next(0,10));
                FilmListBox.Items.Add($"Film {i + 1}");
            }
            FilmListBox.SelectedIndex = 0;
        }
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = RectanglesListBox.SelectedIndex;
            _currentRecrangle = _rectangles[selectedIndex];
            LengthTextBox.Text = _rectangles[selectedIndex].Length.ToString();
            WidthTextBox.Text = _rectangles[selectedIndex].Width.ToString();
            ColorTextBox.Text = _rectangles[selectedIndex].Color;
        }
        private void FilmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = FilmListBox.SelectedIndex;
            _currentFilm = _films[selectedIndex];
            DurationTextBox.Text = _films[selectedIndex].Duration.ToString();
            YearOfIssueTextBox.Text = _films[selectedIndex].YearOfIssue.ToString();
            GenreTextBox.Text = _films[selectedIndex].Genre;
            RatingTextBox.Text = _films[selectedIndex].Rating.ToString();
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
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday weekDay;
            string ParsingWeekDayTextBox = ParsingTextBox.Text;
            if (Enum.TryParse(ParsingWeekDayTextBox, true, out weekDay))
            {
                ParsingLabelOut.Text = $"Этот день недели ({ParsingWeekDayTextBox} = {(int)weekDay})";
            }
            else
            {
                ParsingLabelOut.Text = "Нет такого дня недели";
            }
            ParsingLabelOut.Visible = true;
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

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRecrangle.Length = Double.Parse(LengthTextBox.Text);
                LengthTextBox.BackColor = Color.White;
            }
            catch
            {
                //ToolTip.SetToolTip(LengthTextBox, exception.Message);
                LengthTextBox.BackColor = Color.LightPink;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRecrangle.Width = Double.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = Color.White;
            }
            catch
            {
                //ToolTip.SetToolTip(LengthTextBox, exception.Message);
                WidthTextBox.BackColor = Color.LightPink;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRecrangle.Color = ColorTextBox.Text;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);

        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            FilmListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }
    }
}