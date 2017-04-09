using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
	public static partial class CommonStringExtensions
	{
		/// <summary>
		/// Counts the total amount of occurrences of value within the inputString        
		/// </summary>
		/// <param name="input">The input string for which the total amount of occurrences of value should be counted</param>
		/// <param name="value">The string to find within the input string</param>
		/// <returns>The amount of occurrences of value within the inputString</returns>
        public static int CountSubstring(this string input, string value)
		{
            return CountSubstring(input, value, StringComparison.Ordinal);
		}
        
		/// <summary>
		/// Counts the total amount of occurrences of value at the end of the inputString with an explicitly defined comparisonType
		/// </summary>
        /// <param name="input">The input string for which the total amount of occurrences of value should be counted</param>
        /// <param name="value">The string to find within the input string</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
		/// <returns>The amount of occurrences of value within the inputString</returns>
        public static int CountSubstring(this string input, string value, StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            return CountSubstring(input, value, 0, input.Length, comparisonType);
        }
		/// <summary>
		/// Counts the total amount of occurrences of value at the end of the inputString with an explicitly defined comparisonType
		/// </summary>
        /// <param name="input">The input string for which the total amount of occurrences of value should be counted</param>
        /// <param name="value">The string to find within the input string</param>
        /// <param name="startIndex">The position in this instance where the substring begins</param>
        /// <param name="count">The length of the substring.</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
		/// <returns>The amount of occurrences of value within the inputString</returns>
        public static int CountSubstring(this string input, string value, int startIndex, int count, StringComparison comparisonType)
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

			int occurences = 0;
			int valueLength = value.Length;

			// prevent empty startsWiths from being counted
			if (valueLength > 0)
			{
                int currentIndex = startIndex;
                int maxIndex = startIndex + count;

                while (currentIndex < maxIndex)
                {
                    int lastIndex = currentIndex;
                    int newIndex = input.IndexOf(value, lastIndex, maxIndex - lastIndex, comparisonType);

                    if (newIndex != -1)
                    {
                        occurences++;
                        currentIndex = newIndex + valueLength;
                    }
                    else
                    {
                        break;
                    }
                }
			}

			return occurences;
		}
	}
}
