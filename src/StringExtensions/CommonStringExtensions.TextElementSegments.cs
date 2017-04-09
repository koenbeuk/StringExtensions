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
        /// Get all text element segments within a string
        /// </summary>
        /// <param name="input">The input string to get text element segments for</param>
        /// <returns>A set of 0 or more segments</returns>
        public static IEnumerable<TextElementSegment> TextElementSegments(this string input)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            return TextElementSegmentsCore(input);   
        }

        private static IEnumerable<TextElementSegment> TextElementSegmentsCore(string input)
        {
            int[] elementOffsets = StringInfo.ParseCombiningCharacters(input);

            int lastOffset = -1;
            foreach (int offset in elementOffsets)
            {
                if (lastOffset != -1)
                {
                    int elementLength = offset - lastOffset;
                    TextElementSegment segment = CreateSegment(lastOffset, elementLength);
                    yield return segment;
                }

                lastOffset = offset;
            }

            if (lastOffset != -1)
            {
                int lastSegmentLength = input.Length - lastOffset;

                TextElementSegment segment = CreateSegment(lastOffset, lastSegmentLength);
                yield return segment;
            }
        }

        private static TextElementSegment CreateSegment(int offset, int length)
        {
            return new TextElementSegment(offset, length);
        }
    }
}
