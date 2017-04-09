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
        public string TrimStartOnce(string input, string startsWith)
        {
            string result = CommonStringExtensions.TrimStartOnce(input, startsWith);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            int originalStartsWithCount = CommonStringExtensions.CountSubstringStart(input, startsWith);
            int resultStartsWithCount = CommonStringExtensions.CountSubstringStart(result, startsWith);

            PexAssert.IsTrue(originalStartsWithCount - resultStartsWithCount <= 1);

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string TrimStartOnce(string input, string startsWith, StringComparison comparisonType)
        {
            PexAssume.IsNotNull(input);
            PexAssume.IsNotNull(startsWith);

            string result = CommonStringExtensions.TrimStartOnce(input, startsWith, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            int originalStartsWithCount = CommonStringExtensions.CountSubstringStart(input, startsWith, comparisonType);
            int resultStartsWithCount = CommonStringExtensions.CountSubstringStart(result, startsWith, comparisonType);

            PexAssert.IsTrue(originalStartsWithCount - resultStartsWithCount <= 1);

            return result;
        }
    }
}
