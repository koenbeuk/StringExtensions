using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class TruncateExample
    {
        [TestMethod]
        public void Example1()
        {
            string sample = "This string is clearly to long and should be truncated";
            string ellipsis = "...";
            int maxLength = 20;
            bool inclusiveEllipsis = false; // the ellipsis might be added after the truncated string rather than within the truncated string

            string truncated = sample.Truncate(maxLength, ellipsis, inclusiveEllipsis);

            Assert.AreEqual("This string is clear...", truncated);
            Assert.AreEqual(23, truncated.Length);
        }

        [TestMethod]
        public void Example2()
        {
            string sample = "This string is clearly to long and should be truncated";
            string ellipsis = "...";
            int maxLength = 20;
            bool inclusiveEllipsis = false; // indicates that the ellipsis might be added after the truncated string rather than within the truncated string
            string boundary = " ";
            bool emptyOnNoBoundary = false;
            StringComparison comparisonType = StringComparison.Ordinal;

            string truncated = sample.Truncate(maxLength, ellipsis, inclusiveEllipsis, boundary, emptyOnNoBoundary, comparisonType);

            Assert.AreEqual("This string is...", truncated);
            Assert.AreEqual(17, truncated.Length);
        }
    }
}
