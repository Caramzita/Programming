using System;

namespace ObjectOrientedPractics.Model
{
    static class ItemFactory
    {
        private static Random _random = new Random();

        private static string[] _names = { "Ноутбук ASUS ExpertBook", "Apple iPhone 11", "Ноутбук MSI GF76 Katana", 
            "Робот-пылесос Xiaomi Mi Robot Vacuum", "Смартфон realme 9 Pro", "Игровая консоль Microsoft Xbox Series X", 
            "Смартфон Apple iPhone 13", "Игровая консоль PlayStation 5", "Игровая консоль Microsoft Xbox Series S" };


        private static string[] _info = { "Быстрый процессор iPhone и мощный аккумулятор позволят больше делать " +
                "и тратить меньше времени на подзарядку. ", "Пылесос-робот Xiaomi Mi Robot Vacuum-Mop Essential – " +
                "интеллектуальный помощник для повседневной уборки", "realme 9 Pro оснащен 6.6-дюймовым IPS-экраном " +
                "с разрешением Full HD+ и частотой обновления 120 Гц. ", "Игры, созданные с помощью комплекта разработки " +
                "Xbox Series X|S, демонстрируют значительно сокращенное время загрузки и потрясающие визуальные эффекты на скоростях до 120 к/с.",
                "iPhone 13. Самая совершенная система двух камер на iPhone.", "Высочайшая производительность в самой маленькой консоли Xbox." };

        public static Item Randomize()
        {
            Item item = new Item(_names[_random.Next(_names.Length)], _info[_random.Next(_info.Length)], _random.Next(0, 100000));

            return item;
        }
    }
}
