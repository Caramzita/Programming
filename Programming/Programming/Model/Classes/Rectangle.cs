using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        private static int _allRectanglesCount;

        private int _id;

        public Rectangle()
        {
        }

        public Rectangle(double length,
            double width,
            string color,
            Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Длина");
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
                Validator.AssertOnPositiveValue(value, "Ширина");
                _width = value;
            }
        }

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public Point2D Center { get; set; }
        public string Color { get; set; }

    }
}
