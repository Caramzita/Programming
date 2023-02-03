using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о приоритетном заказе.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Хранит желаемое время доставки
        /// </summary>
        private string _desiredTime;

        /// <summary>
        /// Хранит желаемую дату доставки
        /// </summary>
        public DateTime DesiredDate { get; set; }

        /// <summary>
        /// Возвращает и задает желаемое время доставки.
        /// </summary>
        public string DesiredTime
        {
            get
            {
                return _desiredTime;
            }
            set
            {
                foreach(var intervals in TimeIntervals) 
                {
                    if(value == intervals) 
                    { 
                        _desiredTime = value;
                        return;
                    }
                }

                throw new ArgumentException("Нет такого временного промежутка!");
            }
        }

        /// <summary>
        /// Хранит список всех временных интервалов доставки.
        /// </summary>
        public readonly static List<string> TimeIntervals = new List<string>()
        {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
        };

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="items">Список предметов в заказе.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="fullName">Полное имя покупателя.</param>
        /// <param name="desiredDate">Желаемая дата доставки.</param>
        /// <param name="desiredTime">Желаемое время доставки.</param>
        public PriorityOrder(List<Item> items, Address address, string fullName, DateTime desiredDate, string desiredTime) : base(items, address, fullName)
        {
            DesiredDate = desiredDate;
            DesiredTime = desiredTime;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="items">Список предметов в заказе.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="fullName">Полное имя покупателя.</param>
        /// <param name="desiredDate">Желаемая дата доставки.</param>
        /// <param name="desiredTime">Желаемое время доставки.</param>
        /// <param name="id"></param>
        [JsonConstructor]
        public PriorityOrder(List<Item> items, Address address, string fullName, DateTime desiredDate, string desiredTime, int id) : base(items, address, fullName)
        {
            Items = items;
            Address = address;
            FullName = fullName;
            DesiredDate = desiredDate;
            DesiredTime = desiredTime;
        }
    }
}
