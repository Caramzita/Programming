using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color ErrorColor = Color.LightPink;

        private readonly Color CorrectColor = Color.White;

        private Model.Classes.Rectangle[] _rectangles;

        private Model.Classes.Movies[] _movies;

        private Model.Classes.Rectangle _currentRectangle;

        private Model.Classes.Movies _currentMovie;

        public MainForm()
        {
            InitializeComponent();
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            var currentIndex = -1;
            double max = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    currentIndex = i;
                }
            }
            return currentIndex;
        }

        private int FindMovieWithMaxRating(Model.Classes.Movies[] movies)
        {
            var currentIndex = -1;
            double max = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    currentIndex = i;
                }
            }
            return currentIndex;
        }

        private void MakeMovies()
        {
            Random random = new Random();
            string[] moviesNames = { "The Dark Knight", "The Fly", "The Conjuring",
                "The Thing", "Blade", "Insidious" };
            string[] genres = { " Drama", "Comedy", "Musical",
                "Romance", "Romantic comedy" };
            _movies = new Model.Classes.Movies[6];
            for (int i = 0; i < 6; i++)
            {
                _movies[i] = new Model.Classes.Movies(moviesNames[random.Next(moviesNames.Length)],
                    random.Next(60, 180), random.Next(2000, 2022),
                    genres[random.Next(genres.Length)],
                    random.Next(0, 10));
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
        }

        private void MakeRectangles()
        {
            Random random = new Random();
            string[] colors = { "White", "Black", "Red", "Orange", "Green",
                "Blue", "Brown", "Yellow", "Grey", "Pink" };
            _rectangles = new Model.Classes.Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(random.Next(1, 100),
                    random.Next(1, 100),
                    colors[random.Next(colors.Length)],
                    new Model.Classes.Point2D(random.Next(1, 50), random.Next(1, 50)));
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] enums = { "Color", "EducationForm", "Genre", "Manufactures",
                "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
            ValuesListBox.SelectedIndex = 0;
            SeasonComboBox.Items.Clear();
            foreach (var value in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(value);
            }
            SeasonComboBox.SelectedIndex = 0;
            MakeMovies();
            MakeRectangles();
        }


        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];
            LengthTextBox.Text = _rectangles[selectedIndex].Length.ToString();
            WidthTextBox.Text = _rectangles[selectedIndex].Width.ToString();
            ColorTextBox.Text = _rectangles[selectedIndex].Color;
            XcordTextBox.Text = _rectangles[selectedIndex].Center.X.ToString();
            YcordTextBox.Text = _rectangles[selectedIndex].Center.Y.ToString();
            IdTextBox.Text = _rectangles[selectedIndex].Id.ToString();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndex];
            DurationTextBox.Text = _movies[selectedIndex].Duration.ToString();
            ReleasedDateTextBox.Text = _movies[selectedIndex].ReleasedDate.ToString();
            GenreTextBox.Text = _movies[selectedIndex].Genre;
            RatingTextBox.Text = _movies[selectedIndex].Rating.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Double.Parse(LengthTextBox.Text);
                LengthTextBox.BackColor = CorrectColor;
                ToolTip.SetToolTip(LengthTextBox, "");
            }
            catch(Exception exception)
            {   
                LengthTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(LengthTextBox, exception.Message);
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
                ToolTip.SetToolTip(WidthTextBox, "");
                WidthTextBox.BackColor = CorrectColor;
            }
            catch(Exception exception)
            {
                WidthTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(WidthTextBox, exception.Message);
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Double.Parse(RatingTextBox.Text);
                ToolTip.SetToolTip(RatingTextBox, "");
                RatingTextBox.BackColor = CorrectColor;
            }
            catch(Exception exception)
            {
                RatingTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(RatingTextBox, exception.Message);
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = Int32.Parse(DurationTextBox.Text);
                ToolTip.SetToolTip(DurationTextBox, "");
                DurationTextBox.BackColor = CorrectColor;
            }
            catch(Exception exception)
            {
                DurationTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(DurationTextBox, exception.Message);
                return;
            }
        }

        private void ReleasedDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleasedDate = Int32.Parse(ReleasedDateTextBox.Text);
                ToolTip.SetToolTip(ReleasedDateTextBox, "");
                ReleasedDateTextBox.BackColor = CorrectColor;
            }
            catch(Exception exception)
            {
                ReleasedDateTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(ReleasedDateTextBox, exception.Message);
                return;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
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
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            WeekDay weekDay;
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
    }
}