﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
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
        private static readonly string _itemsdata = @"itemsData.json";

        /// <summary>
        /// Хранит название файла.
        /// </summary>
        private static readonly string _customersdata = @"customersData.json";

        /// <summary>
        /// Выполняет сериализацию.
        /// </summary>
        /// <param name="items"></param>
        public static void SaveToFile(List<Item> items)
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
            using (StreamWriter sw = new StreamWriter(_appDataFolder + _itemsdata))
            using (JsonWriter writer = new JsonTextWriter(sw))

            {
                // Вызываем десериализацию и явно преобразуем результат в тип данных
                serializer.Serialize(writer, items);
            }

        }

        /// <summary>
        /// Выполняет сериализацию.
        /// </summary>
        /// <param name="customers"></param>
        public static void SaveToFile(List<Customer> customers)
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
            using (StreamWriter sw = new StreamWriter(_appDataFolder + _customersdata))
            using (JsonWriter writer = new JsonTextWriter(sw))

            {
                // Вызываем десериализацию и явно преобразуем результат в тип данных
                serializer.Serialize(writer, customers);
            }

        }

        /// <summary>
        /// Выполняет десериализацию.
        /// </summary>
        /// <returns></returns>
        public static List<Item> LoadItemsFromFile()
        {
            // Создаём переменную, в которую поместим результат десериализации
            List<Item> items = null;

            // Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            String folder = _appDataFolder;

            // Проверка наличия пути загрузки.
            if (!Directory.Exists(folder))
            {
                return new List<Item>();
            }

            // Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(_appDataFolder + _itemsdata))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                // Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                items = serializer.Deserialize<List<Item>>(reader);
            }
            return items;
        }

        /// <summary>
        /// Выполняет десериализацию.
        /// </summary>
        /// <returns></returns>
        public static List<Customer> LoadCustomersFromFile()
        {
            // Создаём переменную, в которую поместим результат десериализации
            List<Customer> customers = null;

            // Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            String folder = _appDataFolder;

            // Проверка наличия пути загрузки.
            if (!Directory.Exists(folder))
            {
                return new List<Customer>();
            }

            // Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(_appDataFolder + _customersdata))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                // Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                customers = serializer.Deserialize<List<Customer>>(reader);
            }
            return customers;
        }
    }
}