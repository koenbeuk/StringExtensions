using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Extracts the part from the input string between the first encounter of a couple of enclosure character
        /// </summary>
        /// <param name="input">The input string to take the left part from</param>
        /// <param name="enclosureCharacter">The character to use for checking enclosure</param>
        /// <returns>
        /// The substring starting at the first position after the first encountered enclosure character until the last position before the second enclosure character
        /// or null if no enclosure character combination could be found
        /// </returns>
        public static string Between(this string input, char enclosureCharacter)
        {
            return Between(input, enclosureCharacter, enclosureCharacter);
        }

        /// <summary>
        /// Extracts the part from the input string between the first encounter of a the first enclosure character until the first encounter of the second enclosure character
        /// </summary>
        /// <param name="input">The input string to take the left part from</param>
        /// <param name="firstEnclosureCharacter">The first character to use for checking enclosure</param>
        /// <param name="secondEnclosureCharacter">The second character to use for checking enclosure</param>
        /// <returns>
        /// The substring starting at the first position after the first encountered enclosure character until the last position before the second enclosure character
        /// or null if no enclosure character combination could be found
        /// </returns>
        public static string Between(this string input, char firstEnclosureCharacter, char secondEnclosureCharacter)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            string result;

            int firstEnclosureCharacterIndex = input.IndexOf(firstEnclosureCharacter);
            if (firstEnclosureCharacterIndex == -1 || firstEnclosureCharacterIndex == input.Length - 1)
            {
                result = null;
            }
            else
            {
                int firstAdjustedIndex = firstEnclosureCharacterIndex + 1;
                int secondEnclosureCharacterIndex = input.IndexOf(secondEnclosureCharacter, firstAdjustedIndex);
                if (secondEnclosureCharacterIndex == -1)
                {
                    result = null;
                }
                else
                {
                    int length = secondEnclosureCharacterIndex - firstAdjustedIndex;

                    result = input.Substring(firstAdjustedIndex, length);
                }
            }

            return result;
        }

        /// <summary>
        /// Extracts the part from the input string between the first encounter of a couple of enclosures
        /// </summary>
        /// <param name="input">The input string to take the left part from</param>
        /// <param name="enclosure">The string to use for checking enclosure</param>
        /// <returns>
        /// The substring starting at the first position after the first encountered enclosure until the last position before the second enclosure
        /// or null if no enclosure combination could be found
        /// </returns>
        public static string Between(this string input, string enclosure)
        {         
            return Between(input, enclosure, StringComparison.Ordinal);
        }

        /// <summary>
        /// Extracts the part from the input string between the first encounter of a couple of enclosures
        /// </summary>
        /// <param name="input">The input string to take the left part from</param>
        /// <param name="enclosure">The string to use for checking enclosure</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>
        /// The substring starting at the first position after the first encountered enclosure until the last position before the second enclosure
        /// or null if no enclosure combination could be found
        /// </returns>
        public static string Between(this string input, string enclosure, StringComparison comparisonType)
        {
            return Between(input, enclosure, enclosure, comparisonType);
        }


        /// <summary>
        /// Extracts the part from the input string between the first encounter of a couple of enclosures
        /// </summary>
        /// <param name="input">The input string to take the left part from</param>
        /// <param name="firstEnclosure">The first string to use for checking enclosure</param>
        /// <param name="secondEnclosure">The second string to use for checking enclosure</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>
        /// The substring starting at the first position after the first encountered enclosure until the last position before the second enclosure
        /// or null if no enclosure combination could be found
        /// </returns>
        public static string Between(this string input, string firstEnclosure, string secondEnclosure, StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (firstEnclosure == null)
                throw new ArgumentNullException("firstEnclosure");
            if (secondEnclosure == null)
                throw new ArgumentNullException("secondEnclosure");

            string result;

            int firstEnclosureIndex = input.IndexOf(firstEnclosure, comparisonType);
            if (firstEnclosureIndex == -1 || firstEnclosureIndex + firstEnclosure.Length == input.Length)
            {
                result = null;
            }
            else
            {
                int firstAdjustedIndex = firstEnclosureIndex + firstEnclosure.Length;
                int secondEnclosureIndex = input.IndexOf(secondEnclosure, firstAdjustedIndex, comparisonType);
                if (secondEnclosureIndex == -1)
                {
                    result = null;
                }
                else
                {
                    int length = secondEnclosureIndex - firstAdjustedIndex;

                    result = input.Substring(firstAdjustedIndex, length);
                }
            }

            return result;
        }
    }
}
