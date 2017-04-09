using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Determines whether the input string is empty (0 characters) or consists of only whitespaces
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <returns>True if the input string is empty or consists of only whitespaces</returns>
        public static bool IsEmptyOrWhiteSpace(this string input)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            bool result;

            if (input.Length == 0)
            {
                result = true;
            }
            else
            {
                result = true;

                foreach (char character in input)
                {
                    if (!Char.IsWhiteSpace(character))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
