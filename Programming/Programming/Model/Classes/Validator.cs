using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Проверяет данные на положительность и промежутки.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет значение на положительность.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="fieldName">Название поля.</param>
        public static void AssertOnPositiveValue(double value, string fieldName)
        {
            if(value < 0)
            {
                throw new ArgumentException($"{fieldName} can't be negative");
            }
        }

        /// <summary>
        /// Проверяет значение на промежуток.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение промежутка.</param>
        /// <param name="max">Максимальное значение промежутка.</param>
        /// <param name="fieldName">Название поля.</param>
        public static void AssertValueInRange(double value, int min, int max, string fieldName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{fieldName} does not match the range of numbers from {min} to {max}");
            }
        }
    }
}
