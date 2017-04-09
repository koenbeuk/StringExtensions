using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
	public static partial class CommonStringExtensions
	{
        /// <summary>
        /// Replaces all occurrences of a specified string with another specified string.
        /// This method differs from the version found in the BCL by accepting a StringComparison instance
        /// </summary>
        /// <param name="input">The input string to replace for</param>
        /// <param name="oldValue">The string to replace</param>
        /// <param name="newValue">The string that replaces oldValue</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>A reference to this instance with all instances of oldValue replaced by newValue in the range from startIndex to startIndex + total - 1</returns>
        public static string Replace(this string input, string oldValue, string newValue, StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            return Replace(input, oldValue, newValue, 0, input.Length, comparisonType);
        }

                /// <summary>
        /// Replaces all occurrences of a specified string with another specified string.
        /// </summary>
        /// <param name="input">The input string to replace for</param>
        /// <param name="oldValue">The string to replace</param>
        /// <param name="newValue">The string that replaces oldValue.</param>
        /// <param name="startIndex">The position in this instance where the substring begins</param>
        /// <param name="count">The length of the substring.</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>A reference to this instance with all instances of oldValue replaced by newValue in the range from startIndex to startIndex + total - 1</returns>
        public static string Replace(this string input, string oldValue, string newValue, int startIndex, int count, StringComparison comparisonType)
        {
            int total;

            return Replace(input, oldValue, newValue, startIndex, count, comparisonType, out total);
        }

        /// <summary>
        /// Replaces all occurrences of a specified string with another specified string.
        /// </summary>
        /// <param name="input">The input string to replace for</param>
        /// <param name="oldValue">The string to replace</param>
        /// <param name="newValue">The string that replaces oldValue.</param>
        /// <param name="startIndex">The position in this instance where the substring begins</param>
        /// <param name="count">The length of the substring.</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <param name="total">The total amount of input values that have been replaced</param>
        /// <returns>A reference to this instance with all instances of oldValue replaced by newValue in the range from startIndex to startIndex + total - 1</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "6#", Justification="This API design choice is conform the standard")]
        public static string Replace(this string input, string oldValue, string newValue, int startIndex, int count, StringComparison comparisonType, out int total)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (oldValue == null)
                throw new ArgumentNullException("oldValue");
            if (CommonStringExtensions.IsEmpty(oldValue))
                throw new ArgumentException("oldValue cannot be empty", "oldValue");
            if (startIndex < 0 || startIndex >= input.Length)
                throw new ArgumentOutOfRangeException("startIndex", "startIndex should be between 0 and input.Length");
            if (count < 0 || count > input.Length - startIndex)
                throw new ArgumentOutOfRangeException("count", "count should be larger or equal to 0 and smaller than input.Length - startIndex");

            string result;

            // the initial length of the result for stringBuilder assumes that there is only 1 value to replace
            int initialLength = Math.Max(input.Length - oldValue.Length, 0);
            if (newValue != null)
                initialLength += newValue.Length;

            StringBuilder resultBuilder = new StringBuilder(initialLength);

            if (startIndex > 0)
            {
                resultBuilder.Append(input, 0, startIndex);
            }

            int currentIndex = startIndex;
            int maxIndex = startIndex + count;

            total = 0;

            while (currentIndex < maxIndex)
            {
                int lastIndex = currentIndex;
                int newIndex = input.IndexOf(oldValue, lastIndex, maxIndex - lastIndex, comparisonType);
                
                if (newIndex != -1)
                {
                    resultBuilder.Append(input, lastIndex, newIndex - lastIndex);
                    resultBuilder.Append(newValue);

                    currentIndex = newIndex + oldValue.Length;

                    total++;
                }
                else
                {
                    break;
                }
            }

            // append the final part
            int finalCount = input.Length - currentIndex;
            resultBuilder.Append(input, currentIndex, finalCount);

            result = resultBuilder.ToString();

            return result;
        }
	}
}
