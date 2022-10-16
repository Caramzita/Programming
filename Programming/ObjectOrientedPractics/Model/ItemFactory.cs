using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Создает случайный предмет класса <see cref="Item"/>.
    /// </summary>
    static public class ItemFactory
    {
        /// <summary>
        /// Генерирует случайное значение.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Хранит массив названий.
        /// </summary>
        private static string[] _names = { "Ноутбук ASUS ExpertBook", "Apple iPhone 11", "Ноутбук MSI GF76 Katana", 
            "Робот-пылесос Xiaomi Mi Robot Vacuum", "Смартфон realme 9 Pro", "Игровая консоль Microsoft Xbox Series X", 
            "Смартфон Apple iPhone 13", "Игровая консоль PlayStation 5", "Игровая консоль Microsoft Xbox Series S" };

        /// <summary>
        /// Хранит массив описаний.
        /// </summary>
        private static string[] _info = { "Cовременный ноутбук для корпоративных пользователей. " +
                "Его корпус с минималистическим дизайном выверен в каждой детали,", 
            "Быстрый процессор iPhone и мощный аккумулятор позволят больше делать " +
                "и тратить меньше времени на подзарядку. ", "Этот игровой ноутбук создан для тех, кто хочет получить надежное и " +
                "производительное компьютерное устройство с наиболее востребованным функционалом. ", 
            "Пылесос-робот Xiaomi Mi Robot Vacuum-Mop Essential – " +
                "интеллектуальный помощник для повседневной уборки", "realme 9 Pro оснащен 6.6-дюймовым IPS-экраном " +
                "с разрешением Full HD+ и частотой обновления 120 Гц. ", "Игры, созданные с помощью комплекта разработки " +
                "Xbox Series X|S, демонстрируют значительно сокращенное время загрузки и потрясающие визуальные эффекты на скоростях до 120 к/с.",
                "iPhone 13. Самая совершенная система двух камер на iPhone.", "Поддерживающая технологию Tempest 3D AudioTech игровая консоль PlayStation 5 " +
                "предлагает пользователям возможность насладиться невероятным уровнем качества звука. ",
            "Высочайшая производительность в самой маленькой консоли Xbox." };

        private static Dictionary<string, string> _items = new Dictionary<string, string>();

        public static void AddElemetsInDictionart()
        {
            for (int i = 0; i < _names.Length; i++)
            {
                _items.Add(_names[i], _info[i]);
            }
        }

        /// <summary>
        /// Создает случайный предмет класса <see cref="Item"/>.
        /// </summary>
        /// <returns>Возвращает предмет класса <see cref="Item"/></returns>
        public static Item Randomize()
        {
            var random = _random.Next(_names.Length);

            Item item = new Item(_names[random], _items[_names[random]], _random.Next(0, 100000));

            return item;
        }
    }
}
