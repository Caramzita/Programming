using System;

namespace FlightsApp
{
    public class Flight
    {
        private string _departure;

        private string _destination;

        private DateTime _departureTime;

        private int _duration;

        public Flight()
        {
        }

        public Flight(string departure, 
            string destination, 
            DateTime departureTime, 
            int duration, 
            string flightType)
        {
            Departure = departure;
            Destination = destination;
            DepartureTime = departureTime;
            Duration = duration;
            FlightType = flightType;
        }

        public string Departure
        {
            get
            {
                return _departure;
            }
            set
            {
                AssertStringValue(value);
                _departure = value;
            }
        }

        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                AssertStringValue(value);
                _destination = value;
            }
        }

        public DateTime DepartureTime
        {
            get
            {
                return _departureTime;
            }
            set
            {
                if(value < DateTime.Now)
                {
                    throw new ArgumentException("Время вылета должно быть не ранее сегодняшнего дня");
                }
                _departureTime = value;
            }
        }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if(value < 0 && value > 1000)
                {
                    throw new ArgumentException("Время должно быть положительным и не превышать 1000");
                }
                _duration = value;
            }
        }

        public string FlightType { get; set; }


        private void AssertStringValue(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]) & value[i] != ' ')
                {
                    throw new ArgumentException("Строка не должна содержать цифры");
                }
            }
            if (value.Length > 100)
            {
                throw new ArgumentException("Строка не должна превышать 100 символом");
            }
        }
    }
}
