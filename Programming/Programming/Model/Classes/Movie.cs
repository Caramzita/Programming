using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме: название, жанр, дата выпуска, рейтинг, продолжительность.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Хранит дату выпуска фильма.
        /// </summary>
        private int _releasedDate;

        /// <summary>
        /// Хранит рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Хранит продолжительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Продолжительность фильма. Должна быть положительной.</param>
        /// <param name="releasedDate">Дата выхода фильма. Должна быть больше 1900 года и не больше настоящего.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть положительным и не больше 10.</param>
        public Movie(string name,
            int duration,
            int releasedDate,
            string genre,
            double rating)
        {
            Name = name;
            Duration = duration;
            ReleasedDate = releasedDate;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Возвращает и задает дату выхода фильма. Должна быть больше 1900 года и не больше настоящего.
        /// </summary>
        public int ReleasedDate
        {
            get
            {
                return _releasedDate;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleasedDate));
                _releasedDate = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть положительным и не больше 10.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма. Должна быть положительной.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }
    }
}
