using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        public Rectangle()
        {
        }

        public Rectangle(double length,
            double width,
            string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
                }
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Длина не может быть отрицательной");
                }
                _width = value;
            }
        }

        public string Color { get; set; }
    }
}
