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
        public bool Contains(string input, string value, StringComparison comparisonType)
        {
            bool result = CommonStringExtensions.Contains(input, value, comparisonType);
            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public bool Contains(string input, string value, int startIndex, int count, StringComparison comparisonType)
        {
            bool result = CommonStringExtensions.Contains(input, value, comparisonType);
            return result;
        }
    }
}
