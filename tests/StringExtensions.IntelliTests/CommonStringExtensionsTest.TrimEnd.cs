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
        public string TrimEnd(string input, string endsWith)
        {
            PexAssume.IsNotNull(input);
            PexAssume.IsNotNull(endsWith);

            string result = CommonStringExtensions.TrimEnd(input, endsWith);
            
            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            bool stillEndsWith = result.EndsWith(endsWith, StringComparison.Ordinal);
            bool isEndsWithNotEmpty = endsWith.Length > 0;
            PexAssert.IsTrue(!stillEndsWith || !isEndsWithNotEmpty);

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string TrimEnd(string input, string endsWith, StringComparison comparisonType)
        {
            PexAssume.IsNotNull(input);
            PexAssume.IsNotNull(endsWith);

            string result = CommonStringExtensions.TrimEnd(input, endsWith, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);
            
            bool stillEndsWith = result.EndsWith(endsWith, comparisonType);
            bool isEndsWithNotEmpty = endsWith.Length > 0;
            PexAssert.IsTrue(!stillEndsWith || !isEndsWithNotEmpty);

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string TrimEnd(string input, string endsWith, StringComparison comparisonType, int max)
        {
            string result = CommonStringExtensions.TrimEnd(input, endsWith, comparisonType, max);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            bool isEndsWithNotEmpty = endsWith.Length > 0;

            if (isEndsWithNotEmpty)
            {
                int originalEndsWithCount = CommonStringExtensions.CountSubstringEnd(input, endsWith, comparisonType);
                int resultEndsWithCount = CommonStringExtensions.CountSubstringEnd(result, endsWith, comparisonType);

                PexAssert.IsTrue(resultEndsWithCount == 0 ||
                    resultEndsWithCount == originalEndsWithCount - max);
            }

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string TrimEndsWithMax(string input, string startsWith, StringComparison comparisonType, int max)
        {
            int count;
            string result = CommonStringExtensions.TrimStart(input, startsWith, comparisonType, max, out count);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            bool isStartsWithNotEmpty = startsWith.Length > 0;

            if (isStartsWithNotEmpty)
            {
                int originalStartsWithCount = CommonStringExtensions.CountSubstringStart(input, startsWith, comparisonType);
                int resultStartsWithCount = CommonStringExtensions.CountSubstringStart(result, startsWith, comparisonType);

                PexAssert.IsTrue(resultStartsWithCount == 0 ||
                    resultStartsWithCount == originalStartsWithCount - max);
                PexAssert.IsTrue(originalStartsWithCount - resultStartsWithCount == count);
            }

            return result;
        }
    }
}
