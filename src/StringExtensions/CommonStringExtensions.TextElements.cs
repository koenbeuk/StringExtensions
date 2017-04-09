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
        /// Get all text elements within the input string
        /// </summary>
        /// <param name="input">The input string to get text elements for</param>
        /// <returns>A set of 0 or more elements</returns>
        public static IEnumerable<string> TextElements(this string input)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            return CommonStringExtensions.TextElementCore(input);   
        }

        private static IEnumerable<string> TextElementCore(string input)
        {
            TextElementEnumerator elementEnumerator = StringInfo.GetTextElementEnumerator(input);

            while (elementEnumerator.MoveNext())
            {
                string textElement = elementEnumerator.GetTextElement();
                yield return textElement;
            }
        }
    }
}
