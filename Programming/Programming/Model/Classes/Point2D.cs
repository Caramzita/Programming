﻿using System;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        private int _x;

        private int _y;

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
            
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 250, "Точка х");
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 250, "Точка у");
                _y = value;
            }
        }
    }
}
