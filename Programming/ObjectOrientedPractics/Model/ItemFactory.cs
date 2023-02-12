using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Enums;

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
        private static string[] _names = { "Ноутбук ASUS ExpertBook", "Смартфон Apple iPhone 11", "Ноутбук MSI GF76 Katana", 
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

        /// <summary>
        /// Создает случайный предмет класса <see cref="Item"/>.
        /// </summary>
        /// <returns>Возвращает предмет класса <see cref="Item"/>.</returns>
        public static Item Randomize()
        {
            var random = _random.Next(_names.Length);

            Category category = (Category)Enum.GetValues(typeof(Category)).GetValue(_random.Next(1, 11));

            double randomDouble = Math.Round(_random.NextDouble() * 100000, 2, MidpointRounding.ToEven);

            Item item = new Item(_names[random], _info[random], randomDouble, category);

            return item;
        }
    }
}
