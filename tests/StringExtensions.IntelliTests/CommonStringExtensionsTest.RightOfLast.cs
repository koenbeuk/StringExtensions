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
        public string RightOfLast(string input, char character)
        {
            string result = CommonStringExtensions.RightOfLast(input, character);
            
            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public string RightOfLast(string input, string value)
        {
            string result = CommonStringExtensions.RightOfLast(input, value);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string RightOfLast(string input, string value, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.RightOfLast(input, value, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }
    }
}
