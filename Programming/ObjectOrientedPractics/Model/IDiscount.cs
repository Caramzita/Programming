using System.Collections.ObjectModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Реализует интерфейс скидки.
    /// </summary>
    public interface IDiscount
    {
        string Info { get; }
        double Calculate(ObservableCollection<Item> items);
        double Apply(ObservableCollection<Item> items);
        void Update(ObservableCollection<Item> items);
    }
}
