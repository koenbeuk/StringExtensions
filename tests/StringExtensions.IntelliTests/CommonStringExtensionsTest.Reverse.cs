using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Tests
{
    public partial class CommonStringExtensionsTest
    {
        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string Reverse(string input)
        {
            string result = CommonStringExtensions.Reverse(input);

            PexAssert.IsNotNull(result);
            PexAssert.AreEqual(result.Length, input.Length);

            CollectionAssert.AreEqual(result.ToCharArray(), input.ToCharArray().Reverse().ToArray());

            return result;
        }
    }
}
