using System;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(double value, string fieldName)
        {
            if(value < 0)
            {
                throw new ArgumentException($"{fieldName} can't be negative");
            }
        }

        public static void AssertValueInRange(double value, int min, int max, string fieldName)
        {
            if (value > max || value < min)
            {
                throw new ArgumentException($"{fieldName} does not match the range of numbers from {min} to {max}");
            }
        }
    }
}
