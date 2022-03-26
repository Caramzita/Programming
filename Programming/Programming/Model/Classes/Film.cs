using System;

namespace Programming.Model.Classes
{
    public class Film
    {
        private int _yearOfIssue;
        private double _rating;
        public Film()
        {
        }
        public Film(string name,
            int duration,
            int yearOfIssue,
            string genre,
            double rating)
        {
            Name = name;
            Duration = duration;
            YearOfIssue = yearOfIssue;
            Genre = genre;
            Rating = rating;
        }
        public int YearOfIssue
        {
            get
            {
                return _yearOfIssue;
            }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException(
                        "Год не соответствует требованию");
                }
                _yearOfIssue = value;
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
