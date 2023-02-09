using System;
using System.IO;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using static System.Environment;

namespace ObjectOrientedPractics.Services
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
            @"\Zhelnov OOP\ObjectOrientedPractics\";

        /// <summary>
        /// Хранит название файла.
        /// </summary>
        private static readonly string _storedata = @"storeData.json";

        /// <summary>
        /// Выполняет сериализацию.
        /// </summary>
        /// <param name="store"></param>
        public static void SaveData(Store store)
        {
            // Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include,
                TypeNameHandling = TypeNameHandling.All
            };

            // Проверка наличия пути сохранения
            String folder = _appDataFolder;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // Открываем поток для записи в файл с указанием п
            using (StreamWriter sw = new StreamWriter(_appDataFolder + _storedata))
            using (JsonWriter writer = new JsonTextWriter(sw))

            {
                // Вызываем десериализацию и явно преобразуем результат в тип данных
                serializer.Serialize(writer, store);
            }

        }

        /// <summary>
        /// Выполняет десериализацию.
        /// </summary>
        /// <returns>Возвращает данные класса <see cref="Store"/>.</returns>
        public static Store LoadDataFromFile()
        {
            // Создаём переменную, в которую поместим результат десериализации
            Store store = null;

            // Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include,
                TypeNameHandling = TypeNameHandling.All
            };

            String folder = _appDataFolder;

            // Проверка наличия пути загрузки.
            if (!Directory.Exists(folder))
            {
                return new Store();
            }

            // Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(_appDataFolder + _storedata))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                // Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                store = serializer.Deserialize<Store>(reader);
            }

            return store;
        }
    }
}
