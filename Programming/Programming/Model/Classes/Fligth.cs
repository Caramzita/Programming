using System;

namespace Programming.Model.Classes
{
    public class Fligth
    {
        private int _fligthTime;
        public Fligth()
        {
        }
        public Fligth(string departurePoint,
            string destination,
            int fligthTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FligthTime = fligthTime;
        }
        public int FligthTime
        {
            get
            {
                return _fligthTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина полета не может быть отрицательной");
                }
                _fligthTime = value;
            }
        }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
    }
}
