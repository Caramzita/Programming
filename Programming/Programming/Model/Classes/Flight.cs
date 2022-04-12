using System;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTime;

        public Flight()
        {
        }

        public Flight(string departure,
            string destination,
            int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }

        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Время полета");
                _flightTime = value;
            }
        }

        public string Departure { get; set; }

        public string Destination { get; set; }
    }
}
