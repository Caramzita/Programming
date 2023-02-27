using System.Collections.ObjectModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Реализует интерфейс скидки.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает скидку для текущих товаров.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        double Calculate(ObservableCollection<Item> items);

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        double Apply(ObservableCollection<Item> items);

        /// <summary>
        /// Начисляет скидку на основе полученного списка товаров.
        /// </summary>
        /// <param name="items"></param>
        void Update(ObservableCollection<Item> items);
    }
}
