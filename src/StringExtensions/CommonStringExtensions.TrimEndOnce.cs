using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
	public static partial class CommonStringExtensions
	{
        /// <summary>
        /// Trims the last occurrence of the provided value instance from the end of the input string
        /// </summary>
        /// <param name="input">The input string to trim the last instance of value from</param>
        /// <param name="endsWith">The string to remove from the input string</param>
        /// <returns>The result string trimmed 0 till x times with the value string</returns>
        public static string TrimEndOnce(this string input, string endsWith)
        {
            return TrimEndOnce(input, endsWith, StringComparison.Ordinal);
        }

        /// <summary>
        /// Trims the last occurrence of the provided value instance from the end of the input string
        /// </summary>
        /// <param name="input">The input string to trim the last instance of value from</param>
        /// <param name="endsWith">The string to remove from the input string</param>
        /// <param name="comparisonType">The way value should be compared to the input string</param>
        /// <returns>The result string trimmed 0 till x times with the value string</returns>
        public static string TrimEndOnce(this string input, string endsWith, StringComparison comparisonType)
        {
            return TrimEnd(input, endsWith, comparisonType, 1);
        }
	}
}
