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
        public IEnumerable<string> AllBetween(string input, char enclosureCharacter)
        {
            IEnumerable<string> result = CommonStringExtensions.AllBetween(input, enclosureCharacter);

            PexAssert.IsNotNull(result);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public IEnumerable<string> AllBetween(string input, char firstEnclosureCharacter, char secondEnclosureCharacter)
        {
            IEnumerable<string> result = CommonStringExtensions.AllBetween(input, firstEnclosureCharacter, secondEnclosureCharacter);

            PexAssert.IsNotNull(result);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
        public IEnumerable<string> AllBetween(string input, string enclosure)
        {
            IEnumerable<string> result = CommonStringExtensions.AllBetween(input, enclosure);

            PexAssert.IsNotNull(result);

            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public IEnumerable<string> AllBetween(string input, string enclosure, StringComparison comparisonType)
        {
            IEnumerable<string> result = CommonStringExtensions.AllBetween(input, enclosure, comparisonType);
            return result;
        }

        [PexMethod]
        [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
        public IEnumerable<string> AllBetween(string input, string firstEnclosure, string secondEnclosure, StringComparison comparisonType)
        {           
            IEnumerable<string> result = CommonStringExtensions.AllBetween(input, firstEnclosure, secondEnclosure, comparisonType);
            return result;
        }
    }
}
