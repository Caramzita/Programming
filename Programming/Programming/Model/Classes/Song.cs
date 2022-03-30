using System;

namespace Programming.Model.Classes
{
    public class Song
    {
        private double _duration;

        public Song()
        {
        }

        public Song(string name,
            string artist,
            double duration)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
        }

        public double Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
                }
                _duration = value;
            }
        }

        public string Name { get; set; }

        public string Artist { get; set; }
    }
}
