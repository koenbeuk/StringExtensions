using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;

namespace StringExtensions.Tests
{
    public partial class CommonStringExtensionsTest
    {
        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public int CountSubstring(string input, string value)
        {
            int result = CommonStringExtensions.CountSubstring(input, value);

            PexAssert.IsTrue(result >= 0);
            
            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public int CountSubstring(string input, string value, StringComparison comparisonType)
        {
            int result = CommonStringExtensions.CountSubstring(input, value, comparisonType);

            PexAssert.IsTrue(result >= 0);

            return result;            
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public int CountSubstring(string input, string value, int startIndex, int count, StringComparison comparisonType)
        {
            int result = CommonStringExtensions.CountSubstring(input, value, startIndex, count, comparisonType);

            PexAssert.IsTrue(result >= 0);

            return result;
        }
    }
}
