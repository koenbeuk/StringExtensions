using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class CountSubstringStartExample
    {
        [TestMethod]
        public void Example1()
        {
            // counting a word ignoring cases
            string sample = "How how how many times do i start with how?";

            int howCount = sample.CountSubstringStart("how ", StringComparison.OrdinalIgnoreCase);

            Assert.AreEqual(3, howCount);
        }
    }
}
