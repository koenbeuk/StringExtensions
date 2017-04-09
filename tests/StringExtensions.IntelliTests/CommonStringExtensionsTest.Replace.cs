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
        public string Replace(string input, string oldValue, string newValue, StringComparison comparisonType)
        {
            string result = input.Replace(oldValue, newValue, comparisonType);

            PexAssert.IsNotNull(result);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string Replace(string input, string oldValue, string newValue, int startIndex, int count, StringComparison comparisonType)
        {
            string result = input.Replace(oldValue, newValue, startIndex, count, comparisonType);

            PexAssert.IsNotNull(result);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string ReplaceWithTotal(string input, string oldValue, string newValue, int startIndex, int count, StringComparison comparisonType)
        {
            int total;
            
            string result = input.Replace(oldValue, newValue, startIndex, count, comparisonType, out total);

            PexAssert.IsNotNull(result);
                
            return result;
        }
    }
}
