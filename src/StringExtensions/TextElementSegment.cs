using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public struct TextElementSegment
    {
        private readonly int offset;
        private readonly int length;

        public TextElementSegment(int offset, int length)
        {
            if (offset < 0)
                throw new ArgumentOutOfRangeException("offset should be larger or equal to 0");
            if (length <= 0)
                throw new ArgumentOutOfRangeException("length should be larger than 0");

            this.offset = offset;
            this.length = length;
        }

        public int Offset { get { return offset; } }

        public int Length { get { return length; } }
    }
}
