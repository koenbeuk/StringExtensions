using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Determines whether the input string is empty (0 characters)
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <returns>True if the input string is empty</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        public static bool IsEmpty(this string input)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            return input.Length == 0;
        }
    }
}
