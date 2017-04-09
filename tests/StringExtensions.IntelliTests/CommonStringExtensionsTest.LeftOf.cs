using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;

namespace StringExtensions.Tests
{
    public partial class CommonStringExtensionsTest
    {
        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public string LeftOf(string input, char character)
        {
            string result = CommonStringExtensions.LeftOf(input, character);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string LeftOf(string input, char character, int skip)
        {
            string result = CommonStringExtensions.LeftOf(input, character, skip);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public string LeftOf(string input, string value)
        {
            string result = CommonStringExtensions.LeftOf(input, value);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string LeftOf(string input, string value, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.LeftOf(input, value, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string LeftOf(string input, string value, int skip, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.LeftOf(input, value, skip, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }
    }
}
