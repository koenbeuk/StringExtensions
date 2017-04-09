using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Pex.Framework.Validation;
using Microsoft.Pex.Framework;

namespace StringExtensions.Tests
{
    public partial class CommonStringExtensionsTest
    {
        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public int CountSubstringEnd(string input, string startsWith)
        {
            int result = CommonStringExtensions.CountSubstringEnd(input, startsWith);

            PexAssert.IsTrue(result >= 0);

            return result;
        }

        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public int CountSubstringEnd(string input, string startsWith, StringComparison comparisonType)
        {
            int result = CommonStringExtensions.CountSubstringEnd(input, startsWith, comparisonType);

            PexAssert.IsTrue(result >= 0);

            return result;
        }
    }
}
