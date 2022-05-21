using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Хранит время полета.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Пункт отправление.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="flightTime">Время полета. Должно быть положительным.</param>
        public Flight(string departure,
            string destination,
            int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }

        /// <summary>
        /// Возвращает и задает время полета. Должно быть положительным.
        /// </summary>
        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTime));
                _flightTime = value;
            }
        }

        /// <summary>
        /// Возвращает и задает пункт отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string Destination { get; set; }
    }
}
