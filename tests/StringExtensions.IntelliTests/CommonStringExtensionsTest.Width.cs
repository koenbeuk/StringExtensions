using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using System.Globalization;

namespace StringExtensions.Tests
{
    public partial class CommonStringExtensionsTest
    {
        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public int Width([PexAssumeNotNull]string input)
        {
            // arrange
            int actual = new StringInfo(input).LengthInTextElements;

            // assert
            int result = CommonStringExtensions.Width(input);

            // assert
            PexAssert.AreEqual(actual, result);

            return result;
        }
    }
}
