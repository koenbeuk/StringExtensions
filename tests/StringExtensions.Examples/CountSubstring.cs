using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class CountSubstringExample
    {
        [TestMethod]
        public void Example1()
        {
            // counting a word ignoring cases
            string sample = "How many times do i contain how?";

            int howCount = sample.CountSubstring("how", StringComparison.OrdinalIgnoreCase);

            Assert.AreEqual(2, howCount);
        }

        [TestMethod]
        public void Example2()
        {
            // counting a word within a certain range
            string sample = "ah ah ah ah ah";

            int ahCount = sample.CountSubstring("ah", 4, 9, StringComparison.Ordinal);

            Assert.AreEqual(2, ahCount);
        }
    }
}
