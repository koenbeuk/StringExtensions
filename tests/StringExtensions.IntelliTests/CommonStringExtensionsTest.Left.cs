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
        public string Left(string input, int length)
        {
            string result = CommonStringExtensions.Left(input, length);

            PexAssert.IsNotNull(result);
            PexAssert.AreEqual(result.Length, length);

            return result;
        }
    }
}
