using System;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Выполняет сериализацию и десериализацию.
    /// </summary>
    internal static class ContactSerializer
    {
        /// <summary>
        /// Хранит название файла.
        /// </summary>
        private static readonly string _contactData = @"contacts.json";

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
        /// <param name="contact">Текущий контакт.</param>
        public static void SaveData(Contact contact)
        {
            // Проверка наличия пути сохранения.
            String folder = FilePath;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // Открываем поток для записи в файл с указанием п
            using (StreamWriter sw = new StreamWriter(FilePath + _contactData))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                // Вызываем десериализацию и явно преобразуем результат в тип данных.
                Serializer.Serialize(writer, contact);
            }
        }

        /// <summary>
        /// Выполняет десериализацию.
        /// </summary>
        /// <returns>Возвращает текущий контакт.</returns>
        public static Contact LoadDataFromFile()
        {
            // Создаём переменную, в которую поместим результат десериализации.
            Contact contact = null;

            String folder = FilePath;

            // Проверка наличия пути загрузки.
            if (!Directory.Exists(folder))
            {
                return new Contact();
            }

            // Открываем поток для чтения из файла с указанием пути.
            using (StreamReader sr = new StreamReader(FilePath + _contactData))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                // Вызываем десериализацию и явно преобразуем результат в целевой тип данных.
                contact = Serializer.Deserialize<Contact>(reader);
            }

            return contact;
        }
    }
}
