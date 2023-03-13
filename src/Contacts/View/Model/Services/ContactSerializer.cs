using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    internal static class ContactSerializer
    {
        public static string FilePath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Contacts\";
            }
        }

        private static readonly string _contactData = @"contacts.json";

        public static void SaveData(Contact contact)
        {
            // Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include,
                TypeNameHandling = TypeNameHandling.All
            };

            // Проверка наличия пути сохранения
            String folder = FilePath;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            // Открываем поток для записи в файл с указанием п
            using (StreamWriter sw = new StreamWriter(FilePath + _contactData))
            using (JsonWriter writer = new JsonTextWriter(sw))

            {
                // Вызываем десериализацию и явно преобразуем результат в тип данных
                serializer.Serialize(writer, contact);
            }
        }

        public static Contact LoadDataFromFile()
        {
            // Создаём переменную, в которую поместим результат десериализации
            Contact contact = null;

            // Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Include,
                TypeNameHandling = TypeNameHandling.All
            };

            String folder = FilePath;

            // Проверка наличия пути загрузки.
            if (!Directory.Exists(folder))
            {
                return new Contact();
            }

            // Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(FilePath + _contactData))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                // Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                contact = serializer.Deserialize<Contact>(reader);
            }

            return contact;
        }
    }
}
