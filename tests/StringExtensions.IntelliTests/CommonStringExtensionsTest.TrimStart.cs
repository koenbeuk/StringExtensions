using System;
using System.Linq;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringExtensions;
using Microsoft.Pex.Framework.Instrumentation;

namespace StringExtensions.Tests
{
    public partial class CommonStringExtensionsTest
    {
        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public string TrimStart(string input, string startsWith)
        {
            string result = CommonStringExtensions.TrimStart(input, startsWith);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            bool stillStartsWith = result.StartsWith(startsWith, StringComparison.Ordinal);
            bool isStartsWithNotEmpty = startsWith.Length > 0;
            PexAssert.IsTrue(!stillStartsWith || !isStartsWithNotEmpty);

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string TrimStart(string input, string startsWith, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.TrimStart(input, startsWith, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            bool stillStartsWith = result.StartsWith(startsWith, comparisonType);
            bool isStartsWithNotEmpty = startsWith.Length > 0;
            PexAssert.IsTrue(!stillStartsWith || !isStartsWithNotEmpty);

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string TrimStart(string input, string startsWith, StringComparison comparisonType, int max)
        {
            string result = CommonStringExtensions.TrimStart(input, startsWith, comparisonType, max);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            bool isStartsWithNotEmpty = startsWith.Length > 0;

            if (isStartsWithNotEmpty)
            {
                int originalStartsWithCount = CommonStringExtensions.CountSubstringStart(input, startsWith, comparisonType);
                int resultStartsWithCount = CommonStringExtensions.CountSubstringStart(result, startsWith, comparisonType);

                PexAssert.IsTrue(resultStartsWithCount == 0 ||
                    resultStartsWithCount == originalStartsWithCount - max);
            }

            return result;
        }


        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string TrimStartWithMax(string input, string startsWith, StringComparison comparisonType, int max)
        {
            PexAssume.IsNotNull(input);
            PexAssume.IsNotNull(startsWith);

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
