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
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <param name="propertyName"></param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if(value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }

        public static void AssertIntOnLength(int value, int minLength, int maxLength, string propertyName)
        {
            if (minLength > value || value > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть шестизначным!");
            }
        }
    }
}
