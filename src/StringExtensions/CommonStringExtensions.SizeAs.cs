using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Calculates the amount of bytes occupied by the input string when being encoded as the target encoding
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <param name="targetEncoding">The desired encoding to check for</param>
        /// <returns>The total size of the input string in bytes</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentNullException">targetEncoding is null</exception>
        public static int SizeAs(this string input, Encoding targetEncoding)
        {
            return SizeAs(input, targetEncoding, Encoding.Unicode);
        }

        /// <summary>
        /// Calculates the amount of bytes occupied by the input string encoded as the encoding specified when being encoded as the target encoding
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <param name="targetEncoding">The desired encoding to check for</param>
        /// <param name="sourceEncoding">The encoding of the input string</param>
        /// <returns>The total size of the input string in bytes</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentNullException">sourceEncoding is null</exception>
        /// <exception cref="System.ArgumentNullException">targetEncoding is null</exception>
        public static int SizeAs(this string input, Encoding targetEncoding, Encoding sourceEncoding)
        {
            if (input == null)
                throw new ArgumentNullException("input");
            if (targetEncoding == null)
                throw new ArgumentNullException("targetEncoding");
            if (sourceEncoding == null)
                throw new ArgumentNullException("sourceEncoding");

            byte[] sourceBytes = sourceEncoding.GetBytes(input);

            byte[] targetBytes = Encoding.Convert(sourceEncoding, targetEncoding, sourceBytes);

            return targetBytes.Length;
        }
    }
}
