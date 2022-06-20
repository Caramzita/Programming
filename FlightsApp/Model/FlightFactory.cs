using System;

namespace FlightsApp.Model
{
    /// <summary>
    /// Создает случайный объект класса <see cref="Flight"/>
    /// </summary>
    static class FlightFactory
    {
        /// <summary>
        /// Генерирует случайное значение.
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Хранит данные из перечисления <see cref="FlightType"/>
        /// </summary>
        private static string[] _flightType = Enum.GetNames(typeof(FlightType));

        /// <summary>
        /// Хранит массив городов.
        /// </summary>
        public static string[] Cities = { "Almaty", "Astana", "Ankara", "Amsterdam", "Antwerp", "Bangkok",
            "Barcelona", "Belgrade", "Berlin", "Brasilia", "Brest", "Budapest", "Washington",
            "Vilnius", "Hamburg", "Dallas", "Delhi", "Dublin", "Geneva", "Yokohama", "Kawasaki", "Cairo",
            "Karaganda", "Kiev", "Kyoto", "Kobe", "London", "Los Angeles", "Lisbon", "Luxembourg", "Madrid",
            "Mexico", "Milan", "Minsk", "Nagoya", "New York", "Rome", "San Diego", "Seoul", "San Francisco",
            "Tokyo", "Toronto", "Tbilisi", "Ottawa", "Oslo", "Osaka" };

        /// <summary>
        /// Создает случайный объект класса <see cref="Flight"/>
        /// </summary>
        /// <returns>Возвращает случайный перелет.</returns>
        public static Flight MakeFlights()
        {
            var now = DateTime.Now;
            DateTime randomDate = new DateTime(random.Next(now.Year, 2023),
                random.Next(now.Month, 13), random.Next(now.Day, 31), random.Next(now.Hour, 24),
                random.Next(now.Minute, 60), 0);
            var flight = new Flight(Cities[random.Next(0, Cities.Length)],
                FlightFactory.Cities[random.Next(0, Cities.Length)],
                randomDate, random.Next(1, 1000), _flightType[random.Next(0, 2)]);
            return flight;
        }
    }
}
