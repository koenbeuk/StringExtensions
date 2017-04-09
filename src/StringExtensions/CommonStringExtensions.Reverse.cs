using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Reverses all characters in input
        /// </summary>
        /// <param name="input">The input string to reverse</param>
        /// <returns>A reversed version from input</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        public static string Reverse(this string input)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            return Reverse(input, 0, input.Length);
        }

        /// <summary>
        /// Reverses all characters in input within the range from startIndex till length
        /// </summary>
        /// <param name="input">The input string to reverse</param>
        /// <param name="startIndex">The startIndex startIndex of the input string to begin reversing</param>
        /// <param name="count">The amount of characters to reverse</param>
        /// <returns>A reversed version from input</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">startIndex is smaller than 0 or bigger or equal to input.Length which is bigger than 0</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">count is smaller than 0 or bigger than input.Length + startIndex</exception>
        public static string Reverse(this string input, int startIndex, int count)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (startIndex < 0 || startIndex >= input.Length)
                throw new ArgumentOutOfRangeException("startIndex", "startIndex should be between 0 and input.Length");
            if (count < 0 || count > input.Length - startIndex)
                throw new ArgumentOutOfRangeException("count", "count should be larger or equal to 0 and smaller than input.Length - startIndex");

            string result = input;

            // prevent reversing 0 characters
            if (count > 0)
            {
                char[] characters = input.ToCharArray();

                // reverse the intended characters
                Array.Reverse(characters, startIndex, count);

                result = new string(characters);
            }

            return result;
        }
    }
}
