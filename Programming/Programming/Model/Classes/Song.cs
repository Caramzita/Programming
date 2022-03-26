using System;

namespace Programming.Model.Classes
{
    public class Song
    {
        private double _length;
        public Song()
        {
        }
        public Song(string nameOfTheSong,
            string artistName,
            double length)
        {
            NameOfTheSong = nameOfTheSong;
            ArtistName = artistName;
            Length = length;
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
                }
                _length = value;
            }
        }
        public string NameOfTheSong { get; set; }
        public string ArtistName { get; set; }
    }
}
