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
        public string RightOf(string input, char character)
        {
            string result = CommonStringExtensions.RightOf(input, character);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string RightOf(string input, char character, int skip)
        {
            string result = CommonStringExtensions.RightOf(input, character, skip);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public string RightOf(string input, string value)
        {
            string result = CommonStringExtensions.RightOf(input, value);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string RightOf(string input, string value, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.RightOf(input, value, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string RightOf(string input, string value, int skip, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.RightOf(input, value, skip, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            return result;
        }
    }
}
