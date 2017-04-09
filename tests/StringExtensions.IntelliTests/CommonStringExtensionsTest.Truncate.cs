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
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string Truncate(string input, int length, string ellipsis, bool inclusiveEllipsis, string boundary, bool defaultOnNoBoundary, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.Truncate(input, length, ellipsis, inclusiveEllipsis, boundary, defaultOnNoBoundary, comparisonType);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string Truncate(string input, int length, string ellipsis)
        {
            string result = CommonStringExtensions.Truncate(input, length, ellipsis);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= length);

            if (length < input.Length)
            {
                if (ellipsis != null)
                {
                    PexAssert.IsTrue(result.EndsWith(ellipsis));
                }
            }
            else
            {
                PexAssert.IsTrue(result.StartsWith(input));
            }

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string Truncate(string input, int length, string ellipsis, bool inclusiveEllipsis)
        {
            string result = CommonStringExtensions.Truncate(input, length, ellipsis, inclusiveEllipsis);

            PexAssert.IsNotNull(result);

            int checkLength = Math.Min(length, input.Length);
            if (ellipsis != null && !inclusiveEllipsis)
            {
                checkLength += ellipsis.Length;
            }

            PexAssert.AreEqual(checkLength, result.Length);

            return result;
        }
    }
}
