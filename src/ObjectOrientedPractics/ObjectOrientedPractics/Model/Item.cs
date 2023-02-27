using System;
using ObjectOrientedPractics.Services;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о предметах.
    /// </summary>
    public class Item : ICloneable, IComparable
    {
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
        /// Хранит событие на изменение имени. Зажигается при изменении поля <see cref="_name"/>.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Хранит событие на изменение цены. Зажигается при изменении поля <see cref="_cost"/>.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Хранит событие на изменение информации. Зажигается при изменении поля <see cref="_info"/>.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;

        /// <summary>
        /// Возвращает и задает категорию предмета.
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

                if (_name != value)
                {
                    _name = value;
                    NameChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает информацию о предмете. Не должна превышать 1000 символов.
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

                if (_info != value)
                {
                    _info = value;
                    InfoChanged?.Invoke(this, EventArgs.Empty);
                }
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

                if(_cost != value)
                {
                    _cost = value;
                    CostChanged?.Invoke(this, EventArgs.Empty);
                }             
            }
        }

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get; } 

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Item"/>.
        /// </summary>   
        public Item()
        {
            Id = IdGenerator.GetNextId();
            Name = $"Предмет {this.Id}";
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
            Id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Имя предмета. Не больше 200 символов.</param>
        /// <param name="info">Информация о предмете. Не больше 1000 символов.</param>
        /// <param name="cost">Цена предмета. Должна быть больше 0 и меньше 100 000</param>
        /// <param name="category">Категория товара></param>
        /// <param name="id">Уникальный идентификатор.</param>
        [JsonConstructor]
        public Item(string name, string info, double cost, Category category, int id)
        {
            Id = id;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <inheritdoc />
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            if (!(other is Item))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            Item item = (Item)other;

            return (this.Name == item.Name && this.Info == item.Info && this.Id == item.Id);

        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Item otherItem = obj as Item;

            if (otherItem != null)
            {
                return this.Cost.CompareTo(otherItem.Cost);
            }
            else
            {
                throw new ArgumentException("Объект не Item");
            }
        }

        /// <summary>
        /// Создает клон класса <see cref="Item"/>.
        /// </summary>
        /// <returns>Возвращает клон объекта класса <see cref="Item"/>.</returns>
        public object Clone()
        {
            return new Item(this.Name, this.Info, this.Cost, this.Category);
        }
    }
}
