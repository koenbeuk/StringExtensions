using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Extracts the right part of the input string limited by the first character
        /// </summary>
        /// <param name="input">The input string to take the right part from</param>
        /// <param name="character">The character to find in the input string</param>
        /// <returns>The substring starting at startIndex 0 until either the position of the character (excluding the character) or the whole input string if the character was not found</returns>
        public static string RightOf(this string input, char character)
        {
            return RightOf(input, character, 0);
        }

        /// <summary>
        /// Extracts the right part of the input string limited by the first character
        /// </summary>
        /// <param name="input">The input string to take the right part from</param>
        /// <param name="character">The character to find in the input string</param>
        /// <param name="skip">The numbers of found characters to skip before taking the right part</param>
        /// <returns>The substring starting at startIndex 0 until either the position of the character (excluding the character) or the whole input string if the character was not found</returns>
        public static string RightOf(this string input, char character, int skip)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (skip < 0)
                throw new ArgumentOutOfRangeException("skip", "skip should be larger or equal to 0");

            string result;

            if (input.Length <= skip)
            {
                result = input;
            }
            else
            {
                int characterPosition = input.Length;
                int foundCharacters = -1;

                while (foundCharacters < skip)
                {
                    characterPosition = input.LastIndexOf(character, characterPosition - 1);
                    if (characterPosition == -1)
                    {
                        break;
                    }
                    else
                    {
                        foundCharacters++;

                        if (characterPosition == 0)
                        {
                            break;
                        }
                    }
                }

                if (characterPosition == -1)
                {
                    result = input;
                }
                else
                {
                    result = input.Substring(characterPosition + 1);
                }
            }

            return result;
        }

        /// <summary>
        /// Extracts the right part of the input string limited by the first occurrence of value
        /// </summary>
        /// <param name="input">The input string to take the right part from</param>
        /// <param name="value">The value to find in the input string</param>
        /// <returns>The substring starting at startIndex 0 until either the position of the first occurrence of value or the whole input string if the value was not found</returns>
        public static string RightOf(this string input, string value)
        {
            return RightOf(input, value, StringComparison.Ordinal);
        }

        /// <summary>
        /// Extracts the right part of the input string limited by the first occurrence of value
        /// </summary>
        /// <param name="input">The input string to take the right part from</param>
        /// <param name="value">The value to find in the input string</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>The substring starting at startIndex 0 until either the position of the first occurrence of value or the whole input string if the value was not found</returns>
        public static string RightOf(this string input, string value, StringComparison comparisonType)
        {
            return RightOf(input, value, 0, comparisonType);
        }

        /// <summary>
        /// Extracts the right part of the input string limited by the n'th occurrence of value
        /// </summary>
        /// <param name="input">The input string to take the right part from</param>
        /// <param name="value">The value to find in the input string</param>
        /// <param name="skip">The numbers of found values to skip before taking the right part</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>The substring starting at startIndex 0 until either the position of the first occurrence of value or the whole input string if the value was not found</returns>
        public static string RightOf(this string input, string value, int skip, StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (value == null)
                throw new ArgumentNullException("value");
            if (skip < 0)
                throw new ArgumentOutOfRangeException("skip", "skip should be larger or equal to 0");

            string result;
            if (input.Length <= skip)
            {
                result = input;
            }
            else
            {
                int valuePosition = -1;
                int valuesFound = -1;

                while (valuesFound < skip)
                {
                    valuePosition = input.IndexOf(value, valuePosition + 1, comparisonType);
                    if (valuePosition == -1)
                    {
                        break;
                    }
                    else
                    {
                        valuesFound++;
                    }
                }

                if (valuePosition == -1)
                {
                    result = input;
                }
                else
                {
                    result = input.Substring(valuePosition + value.Length);
                }
            }

            return result;
        }
    }
}
