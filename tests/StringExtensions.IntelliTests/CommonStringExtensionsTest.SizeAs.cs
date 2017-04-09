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
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public int SizeAs(string input, Encoding targetEncoding)
        {
            int result = CommonStringExtensions.SizeAs(input, targetEncoding);

            PexAssert.IsTrue(result >= 0);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public int SizeAs(string input, Encoding targetEncoding, Encoding sourceEncoding)
        {
            int result = CommonStringExtensions.SizeAs(input, targetEncoding, sourceEncoding);

            PexAssert.IsTrue(result >= 0);

            return result;
        }
    }
}
