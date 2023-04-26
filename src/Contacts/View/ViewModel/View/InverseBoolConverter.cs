using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace View.ViewModel.View
{
    public class InverseBoolConverter : IValueConverter
    {
        /// <summary>
        /// Выполняет конвертацию обратную булевому значению.
        /// </summary>
        /// <param name="value">Значение конвертации.</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>Возвращает обратное булевое значение.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        /// <summary>
        /// Выполняет обратную конвертацию.
        /// </summary>
        /// <param name="value">Значение конвертации.</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
