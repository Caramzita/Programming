﻿using System;

namespace ObjectOrientedPractics.Model
{
    class CustomerFactory
    {
        private static Random _random = new Random();

        private static string[] _fullname = { "Борисюк Виктор Семенович", "Кручинкин Михаил Феоктистович", "Бобылёва Настасья Викторовна",
            "Кошелева Кира Ефимовна", "Яхимович Константин Ефимович", "Багров Игнатий Васильевич", "Шабалина Ника Акимовна", 
            "Щеголяева Татьяна Васильевна", "Седельникова Нонна Герасимовна", "Богоносцева Мария Кирилловна", "Онипченко Лариса Дмитриевна",
            "Ячикова Лариса Кузьминовна", "Левченко Юрий Михаилович", "Андреюшкина Ольга Павловна", "Ямщикова Светлана Константиновна" };

        private static string[] _address = { "Россия, г. Бийск, Заводская ул., д. 23 кв.181", "Россия, г. Арзамас, Заречный пер., д. 12 кв.149",
            "Россия, г. Владивосток, Хуторская ул., д. 4 кв.20", "Россия, г. Северодвинск, Советская ул., д. 22 кв.182",
            "Россия, г. Рубцовск, Цветочная ул., д. 22 кв.117", "Россия, г. Тула, Чкалова ул., д. 9 кв.212", 
            "Россия, г. Брянск, Пушкина ул., д. 24 кв.63", "Россия, г. Люберцы, Строителей ул., д. 21 кв.97", 
            "Россия, г. Элиста, Садовый пер., д. 25 кв.217", "Россия, г. Одинцово, Сосновая ул., д. 2 кв.178", 
            "Россия, г. Новокуйбышевск, Лесная ул., д. 13 кв.3", "Россия, г. Смоленск, Первомайский пер., д. 4 кв.61",
            "Россия, г. Подольск, Новая ул., д. 20 кв.94", "Россия, г. Жуковский, Космонавтов ул., д. 20 кв.157" };

        public static Customer Randomize()
        {
            Customer customer = new Customer(_fullname[_random.Next(_fullname.Length)], _address[_random.Next(_address.Length)]);

            return customer;
        }
    }
}