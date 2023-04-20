using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace View.ViewModel.View
{
    /// <summary>
    /// Конвертер для <see cref="Visibility"/> из <see cref="bool"/>.
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Выполняет конвертацию для <see cref="Visibility"/> из <see cref="bool"/>.
        /// </summary>
        /// <param name="value">Значение конвертации.</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>Возвращает значение типа <see cref="Visibility"/>.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isVisibility = (bool)value;

            if (isVisibility)
            {
                return Visibility.Visible;
            }

            return Visibility.Hidden;
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

