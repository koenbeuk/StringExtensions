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
        public string Between(string input, char enclosureCharacter)
        {
            string result = CommonStringExtensions.Between(input, enclosureCharacter);
            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public string Between(string input, char firstEnclosureCharacter, char secondEnclosureCharacter)
        {
            string result = CommonStringExtensions.Between(input, firstEnclosureCharacter, secondEnclosureCharacter);
            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public string Between(string input, string enclosure)
        {
            string result = CommonStringExtensions.Between(input, enclosure);
            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string Between(string input, string enclosure, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.Between(input, enclosure, comparisonType);
            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public string Between(string input, string firstEnclosure, string secondEnclosure, StringComparison comparisonType)
        {
            string result = CommonStringExtensions.Between(input, firstEnclosure, secondEnclosure, comparisonType);
            return result;
        }
    }
}
