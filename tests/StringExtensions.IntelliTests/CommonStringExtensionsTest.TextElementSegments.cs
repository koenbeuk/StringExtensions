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
        public IEnumerable<TextElementSegment> TextElementSegments([PexAssumeNotNull]string input)
        {
            // arrange
            int[] compiningCharacters = StringInfo.ParseCombiningCharacters(input);

            // act
            IEnumerable<TextElementSegment> result = CommonStringExtensions.TextElementSegments(input);

            // assert
            PexAssert.IsNotNull(result);
            PexAssert.AreEqual(compiningCharacters.Count(), result.Count());
      
            return result;
        }
    }
}
