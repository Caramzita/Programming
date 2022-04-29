using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color ErrorColor = Color.LightPink;

        private readonly Color CorrectColor = Color.White;

        private Movies _currentMovie;

        private Movies[] _movies;

        private List<Model.Classes.Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Model.Classes.Rectangle _currentRectangle;

        private Image pictureAddLeave = Image.FromFile(Environment.CurrentDirectory + @"\" + "plus.png");

        private Image pictureAddMove = Image.FromFile(Environment.CurrentDirectory + @"\" + "plus_correct.png");

        private Image pictureRemoveLeave = Image.FromFile(Environment.CurrentDirectory + @"\" + "minus.png");

        private Image pictureRemoveMove = Image.FromFile(Environment.CurrentDirectory + @"\" + "minus_remove.png");

        private string[] colors = { "White", "Black", "Red", "Orange", "Green",
                "Blue", "Brown", "Yellow", "Grey", "Pink" };

        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private int FindRectangleWithMaxWidth(List<Model.Classes.Rectangle> rectangles)
        {
            var currentIndex = -1;
            double max = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    currentIndex = i;
                }
            }
            return currentIndex;
        }

        private int FindMovieWithMaxRating(Movies[] movies)
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

        private void FindCollisions(List<Model.Classes.Rectangle> rectangle)
        {
            
            for(int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(rectangle[i], rectangle[j]))
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                    if (rectangle[i].Center == rectangle[j].Center) 
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 127, 255, 127);
                    }
                }
            }
        }

        private void MakeMovies()
        {
            string[] moviesNames = { "The Dark Knight", "The Fly", "The Conjuring",
                "The Thing", "Blade", "Insidious" };
            string[] genres = { " Drama", "Comedy", "Musical",
                "Romance", "Romantic comedy" };
            _movies = new Movies[6];
            for (int i = 0; i < 6; i++)
            {
                _movies[i] = new Movies(moviesNames[random.Next(moviesNames.Length)],
                    random.Next(60, 180), random.Next(2000, 2022),
                    genres[random.Next(genres.Length)],
                    random.Next(0, 10));
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
        }

        private void MakeRectangles()
        {
            _rectangles = new List<Model.Classes.Rectangle>();
            {
                for (int i = 0; i < 5; i++)
                {
                    _currentRectangle = new Model.Classes.Rectangle();
                    _currentRectangle.Width = random.Next(1, 150);
                    _currentRectangle.Length = random.Next(1, 150);
                    _currentRectangle.Color = colors[random.Next(colors.Length)];
                    _currentRectangle.Center = new Point2D(random.Next(1, 150), random.Next(1, 150));
                    _rectangles.Add(_currentRectangle);
                    RectanglesListBox.Items.Add($"Rectangle {i + 1}");
                    RectanglesPanelListBox.Items.Add($"{_currentRectangle.Id}: " +
                        $"(X = {_currentRectangle.Center.X}; " +
                        $"Y = {_currentRectangle.Center.Y}; " +
                        $"W = {_currentRectangle.Length}; " +
                        $"H = {_currentRectangle.Width})");
                };
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
            _rectangles = new List<Model.Classes.Rectangle>();
            _rectanglePanels = new List<Panel>();
            //MakeRectangles();
            //RectanglesPanelListBox.SelectedIndex = 0;
        }


        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XcordTextBox.Text = _currentRectangle.Center.X.ToString();
            YcordTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndex];
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            ReleasedDateTextBox.Text = _currentMovie.ReleasedDate.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Double.Parse(LengthTextBox.Text);
                LengthTextBox.BackColor = CorrectColor;
                ToolTip.SetToolTip(LengthTextBox, "");
            }
            catch (Exception exception)
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
            catch (Exception exception)
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
            catch (Exception exception)
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
            catch (Exception exception)
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
            catch (Exception exception)
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

        private void RectanglesListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle = _rectangles[RectanglesPanelListBox.SelectedIndex];
                IdPanelTextBox.Text = _currentRectangle.Id.ToString();
                XPanelTextBox.Text = _currentRectangle.Center.X.ToString();
                YPanelTextBox.Text = _currentRectangle.Center.Y.ToString();
                WidthPanelTextBox.Text = _currentRectangle.Length.ToString();
                HeightPanelTextBox.Text = _currentRectangle.Width.ToString();
            }
            catch
            {
                IdPanelTextBox.Clear();
                XPanelTextBox.Clear();
                XPanelTextBox.BackColor = CorrectColor;
                YPanelTextBox.Clear();
                YPanelTextBox.BackColor = CorrectColor;
                WidthPanelTextBox.Clear();
                WidthPanelTextBox.BackColor = CorrectColor;
                HeightPanelTextBox.Clear();
                HeightPanelTextBox.BackColor = CorrectColor;
            }
        }

        private void RectanlgeAddPictureBox_Click(object sender, EventArgs e)
        {
            _currentRectangle = new Model.Classes.Rectangle();
            _currentRectangle.Width = random.Next(1, 250);
            _currentRectangle.Length = random.Next(1, 250);
            _currentRectangle.Color = colors[random.Next(colors.Length)];
            _currentRectangle.Center = new Point2D(random.Next(1, 250), random.Next(1, 250));
            _rectangles.Add(_currentRectangle);
            RectanglesPanelListBox.Items.Add($"{_currentRectangle.Id}: " +
                $"(X = {_currentRectangle.Center.X}; " +
                $"Y = {_currentRectangle.Center.Y}; " +
                $"W = {_currentRectangle.Length}; " +
                $"H = {_currentRectangle.Width})");
            RectanglesPanelListBox.SelectedIndex = _rectangles.Count - 1;
            Panel panel = new Panel();
            panel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            panel.Size = new Size((int)_currentRectangle.Length, (int)_currentRectangle.Width);
            RectanglesPanel.Controls.Add(panel);
            _rectanglePanels.Add(panel);
            FindCollisions(_rectangles);
        }

        private void RecrangleRemovePictureBox_Click(object sender, EventArgs e)
        {
            int index = RectanglesPanelListBox.SelectedIndex;
            FindCollisions(_rectangles);
            if (_rectangles.Count != 0)
            {
                _rectangles.RemoveAt(RectanglesPanelListBox.SelectedIndex);
            }
            RectanglesPanelListBox.Items.Remove(RectanglesPanelListBox.SelectedItem);
            if (index >= 0)
            {
                RectanglesPanelListBox.SelectedIndex = index - 1;
                RectanglesPanel.Controls.RemoveAt(index);
                _rectanglePanels.RemoveAt(index);
            }
        }
        private void XPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = Int32.Parse(XPanelTextBox.Text);
                ToolTip.SetToolTip(XPanelTextBox, "");
                XPanelTextBox.BackColor = CorrectColor;
            }
            catch (Exception exception)
            {
                XPanelTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(XPanelTextBox, exception.Message);
                return;
            }
        }

        private void YPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = Int32.Parse(YPanelTextBox.Text);
                ToolTip.SetToolTip(YPanelTextBox, "");
                YPanelTextBox.BackColor = CorrectColor;
            }
            catch (Exception exception)
            {
                YPanelTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(YPanelTextBox, exception.Message);
                return;
            }
        }

        private void WidthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Int32.Parse(WidthPanelTextBox.Text);
                ToolTip.SetToolTip(WidthPanelTextBox, "");
                WidthPanelTextBox.BackColor = CorrectColor;
            }
            catch (Exception exception)
            {
                WidthPanelTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(WidthPanelTextBox, exception.Message);
                return;
            }
        }

        private void HeightPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.X = Int32.Parse(HeightPanelTextBox.Text);
                ToolTip.SetToolTip(HeightPanelTextBox, "");
                HeightPanelTextBox.BackColor = CorrectColor;
            }
            catch (Exception exception)
            {
                HeightPanelTextBox.BackColor = ErrorColor;
                ToolTip.SetToolTip(HeightPanelTextBox, exception.Message);
                return;
            }
        }

        private void RectanlgeAddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            RectanlgeAddPictureBox.BackgroundImage = pictureAddMove;
        }

        private void RectanlgeAddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            RectanlgeAddPictureBox.BackgroundImage = pictureAddLeave;
        }

        private void RecrangleRemovePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            RecrangleRemovePictureBox.BackgroundImage = pictureRemoveMove;
        }

        private void RecrangleRemovePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RecrangleRemovePictureBox.BackgroundImage = pictureRemoveLeave;
        }
    }
}
