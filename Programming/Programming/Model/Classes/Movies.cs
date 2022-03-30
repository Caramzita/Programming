using System;

namespace Programming.Model.Classes
{
    public class Movies
    {
        private int _releasedDate;

        private double _rating;

        public Movies()
        {
        }

        public Movies(string name,
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

        public int ReleasedDate
        {
            get
            {
                return _releasedDate;
            }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException(
                        "Год должен быть больше 1900");
                }
                _releasedDate = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException(
                        "Рейтинг не соответствует требованию");
                }
                _rating = value;
            }
        }

        public string Name { get; set; }

        public int Duration { get; set; }

        public string Genre { get; set; }
    }
}
