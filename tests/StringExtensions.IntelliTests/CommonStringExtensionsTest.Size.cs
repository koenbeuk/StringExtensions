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
        public int Size(string input)
        {
            int result = CommonStringExtensions.Size(input);

            PexAssert.AreEqual(result, Encoding.Unicode.GetByteCount(input));
            PexAssert.IsTrue(result % 2 == 0); // result must be dividable by 2 since a char is 2 bytes

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public int Size(string input, Encoding encoding)
        {
            int result = CommonStringExtensions.Size(input, encoding);

            PexAssert.IsTrue(result >= 0);

            return result;
        }
    }
}
