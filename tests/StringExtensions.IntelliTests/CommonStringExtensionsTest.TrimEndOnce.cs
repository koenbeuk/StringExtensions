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
        [PexAllowedException(typeof(ArgumentNullException))]
        public string TrimEndOnce(string input, string startsWith)
        {
            string result = CommonStringExtensions.TrimEndOnce(input, startsWith);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            int originalStartsWithCount = CommonStringExtensions.CountSubstringStart(input, startsWith);
            int resultStartsWithCount = CommonStringExtensions.CountSubstringStart(result, startsWith);

            PexAssert.IsTrue(originalStartsWithCount - resultStartsWithCount <= 1);

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string TrimEndOnce(string input, string startsWith, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.TrimEndOnce(input, startsWith, comparisonType);

            PexAssert.IsNotNull(result);
            PexAssert.IsTrue(result.Length <= input.Length);

            int originalStartsWithCount = CommonStringExtensions.CountSubstringStart(input, startsWith);
            int resultStartsWithCount = CommonStringExtensions.CountSubstringStart(result, startsWith);

            PexAssert.IsTrue(originalStartsWithCount - resultStartsWithCount <= 1);

            return result;
        }
    }
}
