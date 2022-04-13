using System;

namespace Programming.Model.Classes
{
    public class Movies
    {
        private int _releasedDate;

        private double _rating;

        private int _duration;

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
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleasedDate));
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
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        public string Name { get; set; }

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

        public string Genre { get; set; }
    }
}
