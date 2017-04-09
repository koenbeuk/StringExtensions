using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Calculates the amount of bytes occupied by the input string
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <returns>The total size of the input string in bytes</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        public static int Size(this string input)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
             
            // simple implementation for utf16 which is the default encoding where chars are of a fixed size
            int result = input.Length * sizeof(char);

            return result;
        }

        /// <summary>
        /// Calculates the amount of bytes occupied by the input string encoded as the encoding specified
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <param name="encoding">The encoding to use</param>
        /// <returns>The total size of the input string in bytes</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentNullException">encoding is null</exception>
        public static int Size(this string input, Encoding encoding)
        {
            if (input == null)
                throw new ArgumentNullException("input");
            if (encoding == null)
                throw new ArgumentNullException("encoding");

            return encoding.GetByteCount(input);
        }
    }
}
