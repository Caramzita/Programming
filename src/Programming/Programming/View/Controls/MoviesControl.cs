using System;
using System.Windows.Forms;
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Хранит данные о выбранном фильме.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Хранит массив всех фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Генерирует случайное значение.
        /// </summary>
        Random _random = new Random();

        public MoviesControl()
        {
            InitializeComponent();
            MakeMovies();
            MovieListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Генерирует случайный фильм вида <see cref="Movie"/>.
        /// </summary>
        private void MakeMovies()
        {
            string[] moviesNames = { "The Dark Knight", "The Fly", "The Conjuring",
                "The Thing", "Blade", "Insidious" };
            string[] genres = { " Drama", "Comedy", "Musical",
                "Romance", "Romantic comedy" };
            _movies = new Movie[6];
            for (int i = 0; i < 6; i++)
            {
                _movies[i] = new Movie(moviesNames[_random.Next(moviesNames.Length)],
                    _random.Next(60, 180), _random.Next(2000, 2022),
                    genres[_random.Next(genres.Length)],
                    _random.Next(0, 10));
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
        }

        /// <summary>
        /// Определяет фильм с наибольшим рейтингом.
        /// </summary>
        /// <param name="movies">Список фильмов.</param>
        /// <returns>Возвращает индекс подходящего фильма.</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
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

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndex];
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            ReleasedDateTextBox.Text = _currentMovie.ReleasedDate.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = Int32.Parse(DurationTextBox.Text);
                ToolTip.SetToolTip(DurationTextBox, "");
                DurationTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                DurationTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(DurationTextBox, exception.Message);
                return;
            }
        }

        private void ReleasedDateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleasedDate = Int32.Parse(ReleasedDateTextBox.Text);
                ToolTip.SetToolTip(ReleasedDateTextBox, "");
                ReleasedDateTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                ReleasedDateTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(ReleasedDateTextBox, exception.Message);
                return;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Double.Parse(RatingTextBox.Text);
                ToolTip.SetToolTip(RatingTextBox, "");
                RatingTextBox.BackColor = AppColors.CorrectColor;
            }
            catch (Exception exception)
            {
                RatingTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(RatingTextBox, exception.Message);
                return;
            }
        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
