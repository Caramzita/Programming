using System;
using System.Collections.ObjectModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы сортировки.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Хранит ссылку на метод.
        /// </summary>
        /// <param name="item1">Предмет 1.</param>
        /// <param name="item2">Предмет 2.</param>
        /// <returns></returns>
        public delegate bool Compare(Item item1, Item item2);

        /// <summary>
        /// Сравнивает два имени предмета по алфавиту.
        /// </summary>
        /// <param name="item1">Предмет 1.</param>
        /// <param name="item2">Предмет 2.</param>
        /// <returns>Возвращает true, если item1 предшествует item2.</returns>
        public static bool CompareByName(Item item1, Item item2)
        {
            return String.Compare(item1.Name, item2.Name) < 0;
        }

        /// <summary>
        /// Сравнивает два предмета по цене. Сравнивает по возрастанию.
        /// </summary>
        /// <param name="item1">Предмет 1.</param>
        /// <param name="item2">Предмет 2.</param>
        /// <returns>Возвращает true, если item1 меньше item2.</returns>
        public static bool CompareByCostAscending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        /// <summary>
        /// Сравнивает два предмета по цене. Сравнивает по убыванию.
        /// </summary>
        /// <param name="item1">Предмет 1.</param>
        /// <param name="item2">Предмет 2.</param>
        /// <returns>Возвращает true, если item1 больше item2.</returns>
        public static bool CompareByCostDescending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }

        /// <summary>
        /// Сортирует список предметов по указанному признаку.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <param name="action">Признак сортировки.</param>
        /// <returns></returns>
        public static ObservableCollection<Item> SortBy(ObservableCollection<Item> items, 
            Predicate<Item> action)
        {
            ObservableCollection<Item> sortedItems = new ObservableCollection<Item>();

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
        /// Сортирует список по принципу, который передадут в делегате compare.
        /// </summary>
        /// <param name="items">Список предметов.</param>
        /// <param name="compare">Принцип сортировки.</param>
        /// <returns>Возвращает отсортированный список.</returns>
        public static ObservableCollection<Item> OrderBy(ObservableCollection<Item> items, 
            Compare compare)
        {
            for(int i = 0; i < items.Count; i++)
            {
                for(int j = 0; j < items.Count; j++)
                {
                    if(compare(items[i], items[j]))
                    {
                        var temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }

            return items;
        }

        /// <inheritdoc/>
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
