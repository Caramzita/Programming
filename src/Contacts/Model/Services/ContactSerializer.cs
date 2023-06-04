using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Model.Services
{
    /// <summary>
    /// Выполняет сериализацию и десериализацию.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Хранит название файла.
        /// </summary>
        private static readonly string _contactsData = @"contacts.json";

        /// <summary>
        /// Возвращает путь файла.
        /// </summary>
        public static string FilePath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Contacts\";
            }
        }

        /// <summary>
        /// Возвращает новый экземпляр класса <see cref="JsonSerializer"/>.
        /// </summary>
        public static JsonSerializer Serializer
        {
            get
            {
                return new JsonSerializer
                {
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Include,
                    TypeNameHandling = TypeNameHandling.All
                };
            }
        }

        /// <summary>
        /// Выполняет сериализацию.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public static void SaveData(ObservableCollection<Contact> contacts)
        {
            // Проверка наличия пути сохранения.
            String folder = FilePath;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // Открываем поток для записи в файл с указанием п
            using (StreamWriter sw = new StreamWriter(FilePath + _contactsData))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                // Вызываем десериализацию и явно преобразуем результат в тип данных.
                Serializer.Serialize(writer, contacts);
            }
        }

        /// <summary>
        /// Выполняет десериализацию.
        /// </summary>
        /// <returns>Возвращает список контактов.</returns>
        public static ObservableCollection<Contact> LoadDataFromFile()
        {
            // Создаём переменную, в которую поместим результат десериализации.
            ObservableCollection<Contact> contacts = null;

            String folder = FilePath;

            // Проверка наличия пути загрузки.
            if (!Directory.Exists(folder))
            {
                return new ObservableCollection<Contact>();
            }

            // Открываем поток для чтения из файла с указанием пути.
            using (StreamReader sr = new StreamReader(FilePath + _contactsData))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                // Вызываем десериализацию и явно преобразуем результат в целевой тип данных.
                contacts = Serializer.Deserialize<ObservableCollection<Contact>>(reader);
            }

            return contacts;
        }
    }
}
