using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Trims the first occurrence of the provided startsWith instance from the start of the input string
        /// </summary>
        /// <param name="input">The input string to trim the first instance of startsWith from</param>
        /// <param name="startsWith">The string to remove from the input string</param>
        /// <returns>The result string trimmed 0 till x times with the startsWith string</returns>
        public static string TrimStartOnce(this string input, string startsWith)
        {
            return TrimStartOnce(input, startsWith, StringComparison.Ordinal);
        }

        /// <summary>
        /// Trims the first occurrence of the provided startsWith instance from the start of the input string
        /// </summary>
        /// <param name="input">The input string to trim the first instance of startsWith from</param>
        /// <param name="startsWith">The string to remove from the input string</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>The result string trimmed 0 till x times with the startsWith string</returns>
        public static string TrimStartOnce(this string input, string startsWith, StringComparison comparisonType)
        {
            return TrimStart(input, startsWith, comparisonType, 1);
        }
    }
}
