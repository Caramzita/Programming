using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени: часы, минуты, секунды.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Хранит часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Хранит минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Хранит секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы. Должны быть положительными и не больше 23.</param>
        /// <param name="minutes">Минуты. Должны быть положительными и не больше 59.</param>
        /// <param name="seconds">Секунды. Должны быть положительными и не больше 59.</param>
        public Time(int hours,
            int minutes,
            int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Возвращает и задает часы. Должны быть положительными и не больше 23.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает минуты. Должны быть положительными и не больше 59.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает секунды. Должны быть положительными и не больше 59.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}
