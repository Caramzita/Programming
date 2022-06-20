using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using static System.Environment;

namespace FlightsApp.Model
{
    public static class ProjectSerializer
    {
        private static readonly string appDataFolder = Environment.GetFolderPath(SpecialFolder.ApplicationData) + 
            @"\Zhelnov\FlightApp\";

        public static string Filename { get; set; }

        public static void SaveToFile(List<Flight> flights)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.NullValueHandling = NullValueHandling.Include;
            serializer.TypeNameHandling = TypeNameHandling.All;

            String folder = appDataFolder;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            using (StreamWriter sw = new StreamWriter(appDataFolder + @"text.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))

            {
                //Вызываем десериализацию и явно преобразуем результат в тип данных
                serializer.Serialize(writer, flights);
            }

    }
    public static List<Flight> LoadFromFile()
        {
            //Создаём переменную, в которую поместим результат десериализации
            List<Flight> flights = null;
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            String folder = appDataFolder;
            if (!Directory.Exists(folder))
            {
                return new List<Flight>();
            }
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(appDataFolder + @"text.txt"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                flights = serializer.Deserialize<List<Flight>>(reader);
            }
            return flights;
        }
    }
}
