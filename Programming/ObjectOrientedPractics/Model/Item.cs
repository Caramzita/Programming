using System;
using ObjectOrientedPractics.Services;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о предметах.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id = IdGenerator.GetNextId();

        /// <summary>
        /// хранит имя предмета.
        /// </summary>
        private string _name;

        /// <summary>
        /// хранит информацию о предмете.
        /// </summary>
        private string _info;

        /// <summary>
        /// хранит цену предмета.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Задает и возвращает категорию предмета.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает имя предмета. Не должно превышать 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о предмете. Не должна превышать 1000 символов
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает цену предмета. Должна быть больше 0 и меньше 100 000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if(value < 0 || value > 100000)
                {
                    throw new ArgumentException("Цена должна быть больше 0 и меньше 100 000");
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Item"/>.
        /// </summary>   
        public Item()
        {
            Name = "";
            Info = "";
            Cost = 0;
            Category = 0;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Имя предмета. Не больше 200 символов.</param>
        /// <param name="info">Информация о предмете. Не больше 1000 символов.</param>
        /// <param name="cost">Цена предмета. Должна быть больше 0 и меньше 100 000</param>
        /// <param name="category">Категория товара></param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        [JsonConstructor]
        public Item(string name, string info, double cost, Category category, int id)
        {
            _id = id;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
    }
}
