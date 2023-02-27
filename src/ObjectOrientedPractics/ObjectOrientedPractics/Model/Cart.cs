using System;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о корзине покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Хранит общую стоимость корзины.
        /// </summary>
        private double _amount = 0.0;

        /// <summary>
        /// Возвращает и задает список предметов.
        /// </summary>
        public ObservableCollection<Item> Items { get; set; }

        /// <summary>
        /// Возвращает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                if(Items == null)
                {
                    return _amount;
                }

                double amount = 0;

                for (int i = 0; i < Items.Count; i++)
                {
                    amount += Items[i].Cost;
                }

                _amount = amount;

                return _amount;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new ObservableCollection<Item>();
        }       

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        [JsonConstructor]
        public Cart(ObservableCollection<Item> items)
        {
            Items = items;
        }

        /// <inheritdoc />
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
        /// Создает клон.
        /// </summary>
        /// <returns>Возвращает клон объекта.</returns>
        public object Clone()
        {
            return new Cart();
        }
    }
}
