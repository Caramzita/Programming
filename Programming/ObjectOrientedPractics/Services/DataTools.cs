using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы сортировки.
    /// </summary>
    internal static class DataTools
    {
        /// <summary>
        /// Сортирует список предметов по указанному признаку.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <param name="action">Признак сортировки.</param>
        /// <returns></returns>
        public static List<Item> SortBy(List<Item> items, Predicate<Item> action)
        {
            List<Item> sortedItems = new List<Item>();

            foreach (Item item in items)
            {
                if (action(item))
                {
                    sortedItems.Add(item);
                }
            }

            return sortedItems;
        }

        /// <summary>
        /// Сортирует предметы по указанному списку.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <param name="setting">Признак сортировки.</param>
        /// <returns></returns>
        public static List<Item> OrderBy(List<Item> items, Func<object, object, bool> setting)
        {
            for(int i = 0; i < items.Count; i++)
            {
                for(int j = 1; j < items.Count; j++)
                {
                    if(setting(items[i], items[j]))
                    {
                        var temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

            return items;
        }

        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
