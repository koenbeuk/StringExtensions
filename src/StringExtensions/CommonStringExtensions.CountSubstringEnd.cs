using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StringExtensions
{
	public static partial class CommonStringExtensions
	{
		/// <summary>
		/// Counts the total amount of occurrences of value at the end of the inputString        
		/// </summary>
		/// <param name="input">The input string for which the total amount of occurrences of value should be counted</param>
		/// <param name="endsWith">The string to repeatable total at the end of the input string</param>
		/// <returns>The amount of occurrences of value at the end of inputString</returns>
        public static int CountSubstringEnd(this string input, string endsWith)
		{
			return CountSubstringEnd(input, endsWith, StringComparison.Ordinal);
		}


		/// <summary>
		/// Counts the total amount of occurrences of value at the end of the inputString with an explicitly defined comparisonType
		/// </summary>
		/// <param name="input">The input string for which the total amount of occurrences of value should be counted</param>
		/// <param name="endsWith">The string to repeatable total at the end of the input string</param>
		/// <param name="comparisonType">The way startsWith should be compared to the input string</param>
		/// <returns>The amount of occurrences of value at the end of inputString</returns>
        public static int CountSubstringEnd(this string input, string endsWith, StringComparison comparisonType)
		{
			// preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (endsWith == null)
                throw new ArgumentNullException("endsWith");

			int occurences = 0;
			int endsWithLength = endsWith.Length;

			// prevent empty startsWiths from being counted
			if (endsWithLength > 0)
			{
				string currentComparand = input;

				// keep on looping until no occurrence is found which is guarded by the break statement
				while (true)
				{
					bool occurenceResult = currentComparand.EndsWith(endsWith, comparisonType);

					if (occurenceResult)
					{
						occurences++;
						currentComparand = currentComparand.Substring(0, currentComparand.Length - endsWithLength);
					}
					else
					{
						break;
					}
				}
			}

			return occurences;
		}
	}
}
