using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Хранит список предметов.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Хранит общую стоимость корзины.
        /// </summary>
        private double _amount = 0.0;

        /// <summary>
        /// Возвращает и задает список предметов.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                if(_items == null)
                {
                    return _amount;
                }

                double amount = 0;

                for (int i = 0; i < _items.Count; i++)
                {
                    amount += _items[i].Cost;
                }

                _amount = amount;

                return _amount;
            }
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            if (!(other is Cart))
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            Cart cart = (Cart)other;

            return (this.Items == cart.Items && this.Amount == cart.Amount);

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Создает клон.
        /// </summary>
        /// <returns>Возвращает клон объекта.</returns>
        public object Clone()
        {
            return new Cart();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        [JsonConstructor]
        public Cart(List<Item> items)
        {
            Items = items;
        }
    }
}
