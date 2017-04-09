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
        public string LeftOfLast(string input, char character)
        {
            string result = CommonStringExtensions.LeftOfLast(input, character);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public string LeftOfLast(string input, string value)
        {
            string result = CommonStringExtensions.LeftOfLast(input, value);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string LeftOfLast(string input, string value, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.LeftOfLast(input, value, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }
    }
}
