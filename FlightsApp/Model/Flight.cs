using System;

namespace FlightsApp
{
    /// <summary>
    /// Хранит данные о перелете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Хранит точку отправления.
        /// </summary>
        private string _departure;

        /// <summary>
        /// Хранит точку прибытия.
        /// </summary>
        private string _destination;

        /// <summary>
        /// Хранит время вылета.
        /// </summary>
        private DateTime _departureTime;

        /// <summary>
        /// Хранит продолжительность перелета.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Точка отправления.</param>
        /// <param name="destination">Точка прибытия.</param>
        /// <param name="departureTime">Время вылета.</param>
        /// <param name="duration">Продолжительность полета.</param>
        /// <param name="flightType">Тип перелета.</param>
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
        
        /// <summary>
        /// Возвращает и задает точку отправления. Должна содержать только буквы.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает точку прибытия. Должна содержать только буквы.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает время вылета. Не должно быть раньше сегодняшнего дня.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает продолжительность перелета. Должно быть положительным и не больше 1000.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает тип перелета.
        /// </summary>
        public string FlightType { get; set; }


        /// <summary>
        /// Проверяет, состоит ли строка только из букв.
        /// </summary>
        /// <param name="value">Передаваемая строка.</param>
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
