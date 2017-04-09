using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Converts the input string to the target encoding
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <param name="targetEncoding">The desired encoding to convert to</param>
        /// <returns>The input string converted in the targetEncoding</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentNullException">targetEncoding is null</exception>
        public static string Convert(this string input, Encoding targetEncoding)
        {
            return Convert(input, targetEncoding, Encoding.Unicode);
        }

        /// <summary>
        /// Converts the input string encoded as the encoding specified to the target encoding
        /// </summary>
        /// <param name="input">The input string to check</param>
        /// <param name="targetEncoding">The desired encoding to convert to</param>
        /// <param name="sourceEncoding">The encoding of the input string</param>
        /// <returns>The input string converted in the targetEncoding</returns>
        /// <exception cref="System.ArgumentNullException">input is null</exception>
        /// <exception cref="System.ArgumentNullException">sourceEncoding is null</exception>
        /// <exception cref="System.ArgumentNullException">targetEncoding is null</exception>
        public static string Convert(this string input, Encoding targetEncoding, Encoding sourceEncoding)
        {
            if (input == null)
                throw new ArgumentNullException("input");
            if (targetEncoding == null)
                throw new ArgumentNullException("targetEncoding");
            if (sourceEncoding == null)
                throw new ArgumentNullException("sourceEncoding");

            byte[] sourceBytes = sourceEncoding.GetBytes(input);

            byte[] targetBytes = Encoding.Convert(sourceEncoding, targetEncoding, sourceBytes);

            string result = targetEncoding.GetString(targetBytes, 0, targetBytes.Length);

            return result;
        }
    }
}
