using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using static System.Environment;

namespace FlightsApp.Model
{
    /// <summary>
    /// Выполняет сериализацию и десериализацию.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Хранит путь файла сохранения и загрузки.
        /// </summary>
        private static readonly string _appDataFolder = Environment.GetFolderPath(SpecialFolder.ApplicationData) + 
            @"\Zhelnov\FlightApp\";

        /// <summary>
        /// Хранит название файла.
        /// </summary>
        private static readonly string _userdata = @"userdata.json";

        /// <summary>
        /// Выполняет сериализацию.
        /// </summary>
        /// <param name="flights"></param>
        public static void SaveToFile(List<Flight> flights)
        {
            // Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.NullValueHandling = NullValueHandling.Include;
            serializer.TypeNameHandling = TypeNameHandling.All;

            // Проверка наличия пути сохранения
            String folder = _appDataFolder;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // Открываем поток для записи в файл с указанием п
            using (StreamWriter sw = new StreamWriter(_appDataFolder + _userdata))
            using (JsonWriter writer = new JsonTextWriter(sw))

            {
                // Вызываем десериализацию и явно преобразуем результат в тип данных
                serializer.Serialize(writer, flights);
            }

        }

        /// <summary>
        /// Выполняет десериализацию.
        /// </summary>
        /// <returns></returns>
        public static List<Flight> LoadFromFile()
        {
            // Создаём переменную, в которую поместим результат десериализации
            List<Flight> flights = null;

            // Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            String folder = _appDataFolder;

            // Проверка наличия пути загрузки.
            if (!Directory.Exists(folder))
            {
                return new List<Flight>();
            }

            // Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(_appDataFolder + _userdata))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                // Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                flights = serializer.Deserialize<List<Flight>>(reader);
            }
            return flights;
        }
    }
}
