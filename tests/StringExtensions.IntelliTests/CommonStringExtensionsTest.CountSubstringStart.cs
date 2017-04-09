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
        [PexAllowedException(typeof(ArgumentNullException))]
        public int CountSubstringStart(string input, string startsWith)
        {
            int result = CommonStringExtensions.CountSubstringStart(input, startsWith);

            PexAssert.IsTrue(result >= 0);

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public int CountSubstringStart(string input, string startsWith, StringComparison comparisonType)
        {
            int result = CommonStringExtensions.CountSubstringStart(input, startsWith, comparisonType);

            PexAssert.IsTrue(result >= 0);
            
            return result;            
        }
    }
}
