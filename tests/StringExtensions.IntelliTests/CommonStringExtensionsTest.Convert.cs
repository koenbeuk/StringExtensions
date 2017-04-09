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
        public string Convert(string input, Encoding targetEncoding)
        {
            string result = CommonStringExtensions.Convert(input, targetEncoding);

            PexAssert.IsTrue(result != null);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public string Convert(string input, Encoding targetEncoding, Encoding sourceEncoding)
        {
            string result = CommonStringExtensions.Convert(input, targetEncoding, sourceEncoding);

            PexAssert.IsTrue(result != null);

            return result;
        }
    }
}
