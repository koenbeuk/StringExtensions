using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Extracts the right part of the input string limited with the length parameter
        /// </summary>
        /// <param name="input">The input string to take the right part from</param>
        /// <param name="length">The amount of characters to take from the input string</param>
        /// <returns>The substring taken from the input string</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Length is smaller than zero or higher than the length of input</exception>
        public static string Right(this string input, int length)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (length < 0 || length > input.Length)
                throw new ArgumentOutOfRangeException("length", "length cannot be higher than the amount of available characters in the input or lower than 0");

            int startIndex = input.Length - length;
            string result = input.Substring(startIndex);

            return result;
        }
    }
}
