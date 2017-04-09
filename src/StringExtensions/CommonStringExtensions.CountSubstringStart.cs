using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Counts the total amount of occurrences of startsWith at the start of inputString        
        /// </summary>
        /// <param name="input">The input string for which the total amount of occurrences of startsWith should be counted</param>
        /// <param name="startsWith">The string to repeatable total at the start of the input string</param>
        /// <returns>The amount of occurrences of startsWith at the start of inputString</returns>
        public static int CountSubstringStart(this string input, string startsWith)
        {
            return CountSubstringStart(input, startsWith, StringComparison.Ordinal);
        }

        /// <summary>
        /// Counts the total amount of occurrences of startsWith at the start of inputString        
        /// </summary>
        /// <param name="input">The input string for which the total amount of occurrences of startsWith should be counted</param>
        /// <param name="startsWith">The string to repeatable total at the start of the input string</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>The amount of occurrences of startsWith at the start of inputString</returns>
        public static int CountSubstringStart(this string input, string startsWith, StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (startsWith == null)
                throw new ArgumentNullException("startsWith");

            int occurences = 0;
            int startsWithLength = startsWith.Length;

            // prevent empty startsWiths from being counted
            if (startsWithLength > 0)
            {
                string currentComparand = input;

                // keep on looping until no occurrence is found which is guarded by the break statement
                while (true)
                {
                    bool occurenceResult = currentComparand.StartsWith(startsWith, comparisonType);

                    if (occurenceResult)
                    {
                        occurences++;
                        currentComparand = currentComparand.Substring(startsWithLength);
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
