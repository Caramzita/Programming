using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Создает случайного покупателя класса <see cref="Customer"/>.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Генерирует случайное значение.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Хранит массив имен.
        /// </summary>
        private static string[] _fullName = 
            { 
            "Борисюк Виктор Семенович", 
            "Кручинкин Михаил Феоктистович", 
            "Бобылёва Настасья Викторовна",
            "Кошелева Кира Ефимовна", 
            "Яхимович Константин Ефимович", 
            "Багров Игнатий Васильевич", 
            "Шабалина Ника Акимовна",
            "Щеголяева Татьяна Васильевна", 
            "Седельникова Нонна Герасимовна", 
            "Богоносцева Мария Кирилловна", 
            "Онипченко Лариса Дмитриевна",
            "Ячикова Лариса Кузьминовна", 
            "Левченко Юрий Михаилович", 
            "Андреюшкина Ольга Павловна",
            "Ямщикова Светлана Константиновна" 
            };

        /// <summary>
        /// Хранит массив адресов.
        /// </summary>
        private static string[] _city = 
            { 
            "г. Бийск", 
            "г. Арзамас", 
            "г. Владивосток", 
            "г. Северодвинск", 
            "г. Рубцовск", 
            "г. Тула", 
            "г. Брянск", 
            "г. Люберцы", 
            "г. Элиста", 
            "г. Одинцово", 
            "г. Новокуйбышевск", 
            "г. Смоленск",
            "г. Подольск", 
            "г. Жуковский"
            };

        /// <summary>
        /// Хранит массив улиц.
        /// </summary>
        private static string[] _street = 
            { 
            "Заводская ул.", 
            "Заречный пер.", 
            "Хуторская ул.", 
            "Советская ул.", 
            "Цветочная ул.",
            "Чкалова ул.", 
            "Пушкина ул.",
            "Строителей ул.", 
            "Садовый пер.", 
            "Сосновая ул.", 
            "Лесная ул.", 
            "Первомайский пер.",
            "Новая ул.", 
            "Космонавтов ул." 
            };

        /// <summary>
        /// Создает случайного покупателя класса <see cref="Customer"/>.
        /// </summary>
        /// <returns>Возвращает прямоугольник класса <see cref="Customer"/></returns>
        public static Customer Randomize()
        {
            int index = _random.Next(100000, 1000000);
            string randomCity = _city[_random.Next(_city.Length)];
            string randomStreet = _street[_random.Next(_street.Length)];
            string randomFullname = _fullName[_random.Next(_fullName.Length)];

            Address address = new Address(index, "Россия", randomCity, randomStreet, 
                $"д. {_random.Next(1, 25)}", 
                $"к.{_random.Next(1, 150)}");

            Customer customer = new Customer(randomFullname, address);

            return customer;
        }
    }
}
