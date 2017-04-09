using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Truncates the input string given to the length specified and possibly adds an ellipsis at the end to mark a truncation
        /// </summary>
        /// <param name="input">The input string to truncate</param>
        /// <param name="length">The desired maximum length of the resulting string</param>
        /// <param name="ellipsis">An ellipsis to append to the end of a string when it gets truncated or null if no ellipsis is required</param>
        /// <returns>The input string possibly truncated at the desired length with the ellipsis added. The length of the resulting string will never exceed the length specified</returns>
        
        public static string Truncate(this string input, int length, string ellipsis)
        {
            return Truncate(input, length, ellipsis, true);
        }

        /// <summary>
        /// Truncates the input string given to the length specified and possibly adds an ellipsis at the end to mark a truncation
        /// </summary>
        /// <param name="input">The input string to truncate</param>
        /// <param name="length">The desired maximum length of the resulting string</param>
        /// <param name="ellipsis">An ellipsis to append to the end of a string when it gets truncated or null if no ellipsis is required</param>
        /// <param name="inclusiveEllipsis">True if the ellipsis should be taken into account when checking for the length. 
        /// If false, the input string will be cut of at the length specified and the ellipsis will be added even if that means the resulting string will be longer than the desired length</param>
        /// <returns>The input string possibly truncated at the desired length with the ellipsis added</returns>
        
        public static string Truncate(this string input, int length, string ellipsis, bool inclusiveEllipsis)
        {
            return Truncate(input, length, ellipsis, inclusiveEllipsis, null, false, StringComparison.Ordinal);
        }

        /// <summary>
        /// Truncates the input string given to the length specified and possibly adds an ellipsis at the end to mark a truncation
        /// </summary>
        /// <param name="input">The input string to truncate</param>
        /// <param name="length">The desired maximum length of the resulting string</param>
        /// <param name="ellipsis">An ellipsis to append to the end of a string when it gets truncated or null if no ellipsis is required</param>
        /// <param name="inclusiveEllipsis">True if the ellipsis should be taken into account when checking for the length. 
        /// If false, the input string will be cut of at the length specified and the ellipsis will be added even if that means the resulting string will be longer than the desired length</param>
        /// <param name="boundary">A string (e.g. space) on which to break.</param>
        /// <param name="emptyOnNoBoundary">Determines the default behavior When no boundary is found. (Empty string or truncate without boundary)</param>
        /// <param name="comparisonType">The way boundary should be compared to the input string</param>
        /// <returns>The input string possibly truncated at the desired length with the ellipsis added</returns>
        
        public static string Truncate(this string input,
            int length,
            string ellipsis,
            bool inclusiveEllipsis,
            string boundary,
            bool emptyOnNoBoundary,
            StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (length < 0)
                throw new ArgumentOutOfRangeException("length", "length cant be smaller than 0");

            // the length of ellipsis might not be larger than the desired length of the resulting string when inclusiveEllipsis is set
            if (ellipsis != null)
            {
                if (inclusiveEllipsis)
                {
                    if (ellipsis.Length > length)
                        throw new ArgumentException("Ellipsis cant be larger than the desired length when inclusiveEllipsis is set", "ellipsis");
                }
            }

            string result = input;

            if (input.Length > length)
            {
                int checkLength = length;

                if (inclusiveEllipsis && !string.IsNullOrEmpty(ellipsis))
                {
                    // ensure that we leave space for the ellipsis
                    checkLength -= ellipsis.Length;
                }
                if (!string.IsNullOrEmpty(boundary))
                {
                    int boundaryIndex = input.LastIndexOf(boundary, checkLength, checkLength, comparisonType);
                    if (boundaryIndex != -1)
                    {
                        int boundaryLength = boundaryIndex; // we want to stop right before the boundary starts so we can use the index of the boundary as the length.

                        result = input.Left(boundaryLength);
                    }
                    else
                    {
                        if (emptyOnNoBoundary)
                        {
                            result = string.Empty;
                        }
                        else
                        {
                            result = input.Left(length);
                        }
                    }
                }
                else
                {
                    result = input.Left(checkLength);
                }

                if (!string.IsNullOrEmpty(ellipsis))
                {
                    result += ellipsis;
                }
            }
            else
            {
                if (!inclusiveEllipsis)
                {
                    if (ellipsis != null)
                    {
                        result += ellipsis;
                    }
                }
            }

            return result;
        }
    }
}
