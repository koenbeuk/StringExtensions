using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Determines whether the given value can be located within the input string
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <param name="value">The value to check within the input string</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>True if the value was found within the input string</returns>
        public static bool Contains(this string input, string value, StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            return Contains(input, value, 0, input.Length, comparisonType);
        }

        /// <summary>
        /// Determines whether the given value can be located within the input string given the specified range
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <param name="value">The value to check within the input string</param>
        /// <param name="startIndex">The position in this instance where the substring begins</param>
        /// <param name="count">The length of the substring.</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>True if the value was found within the input string</returns>
        public static bool Contains(this string input, string value, int startIndex, int count, StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (value == null)
                throw new ArgumentNullException("value");
            if (startIndex < 0 || startIndex >= input.Length)
                throw new ArgumentOutOfRangeException("startIndex", "startIndex should be between 0 and input.Length");
            if (count < 0 || count > input.Length - startIndex)
                throw new ArgumentOutOfRangeException("count", "count should be larger or equal to 0 and smaller than input.Length - startIndex");

            int firstIndex = input.IndexOf(value, startIndex, count, comparisonType);

            bool result = firstIndex != -1;

            return result;
        }
    }
}
