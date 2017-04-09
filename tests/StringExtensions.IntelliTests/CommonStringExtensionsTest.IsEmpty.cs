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
        public bool IsEmpty(string input)
        {
            bool result = CommonStringExtensions.IsEmpty(input);

            PexAssert.AreEqual(result, input == string.Empty);

            return result;
        }
    }
}
