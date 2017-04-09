using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Calculates the amount of printable characters within this string. This includes surrogate pairs and mark characters
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <returns>The n number of printable characters (hence width)</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        public static int Width(this string input)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            TextElementEnumerator elementEnumerator = StringInfo.GetTextElementEnumerator(input);
            int count = 0;

            while (elementEnumerator.MoveNext())
            {
                count++;
            }

            return count;
        }
    }
}
