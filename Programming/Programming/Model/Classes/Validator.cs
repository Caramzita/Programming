using System;

namespace Programming.Model.Classes
{
    public class Validator
    {
        public static void AssertOnPositiveValue(double value, string nameField)
        {
            if(value < 0)
            {
                throw new ArgumentException($"{nameField} не может быть отрицальным");
            }
        }

        public static void AssertValueInRange(double value, int min, int max, string nameField)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{nameField} не соответствует требованию");
            }
        }
    }
}
