using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class CountSubstringEndExample
    {
        [TestMethod]
        public void Example1()
        {
            // counting a word ignoring cases
            string sample = "How many times do i end with how how";

            int howCount = sample.CountSubstringEnd(" how");

            Assert.AreEqual(2, howCount);
        }
    }
}
