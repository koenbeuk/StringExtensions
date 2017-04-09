using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class ContainsExample
    {
        [TestMethod]
        public void Example1()
        {
            // contains now allows the specification of a StringComparison instance and therefore is able to match both characters
            string sample = "This is a sample containing CAPITALIZED content";

            Assert.IsTrue(sample.Contains("capitalized", StringComparison.OrdinalIgnoreCase));
        }

        [TestMethod]
        public void Example2()
        {
            // below are 2 linguistically equivalent characters.
            // contains now allows the specification of a StringComparison instance and therefore is able to match both characters
            string weirdCharacter1 = "\u00c5";
            string weirdCharacter2= "\u0061\u030a";

            string sample = "This is a sample containing " + weirdCharacter2;

            Assert.IsTrue(weirdCharacter1.Equals(weirdCharacter2, StringComparison.CurrentCultureIgnoreCase));

            Assert.IsTrue(sample.Contains(weirdCharacter1, StringComparison.CurrentCultureIgnoreCase));
            Assert.IsFalse(sample.Contains(weirdCharacter1, StringComparison.OrdinalIgnoreCase));
        }
    }
}
