using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Проверяет данные на длину строки.
    /// </summary>
    static class ValueValidator
    {
        /// <summary>
        /// Проверяет строку на допустимую длину.
        /// </summary>
        /// <param name="value">входное значение.</param>
        /// <param name="maxLength">максимальная длина.</param>
        /// <param name="propertyName">имя объекта.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if(value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }

        /// <summary>
        /// Проверяет число на значимость.
        /// </summary>
        /// <param name="value">входное значение.</param>
        /// <param name="minLength">минимальная длина.</param>
        /// <param name="maxLength">максимальная длина.</param>
        /// <param name="propertyName">имя объекта.</param>
        public static void AssertIntOnLength(int value, int minLength, int maxLength, string propertyName)
        {
            if (minLength > value || value > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть шестизначным!");
            }
        }
    }
}
