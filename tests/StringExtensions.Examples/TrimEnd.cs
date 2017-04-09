using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class TrimEndExample
    {
        [TestMethod]
        public void Example1()
        {
            // Simply trim a postfix from the sample
            string sample = "sample test";

            string trimmed = sample.TrimEnd(" test", StringComparison.Ordinal);

            Assert.AreEqual(trimmed, "sample");
        }

        [TestMethod]
        public void Example2()
        {
            // Trim only the last instance from the sample
            string sample = "test test test";

            string trimmed1 = sample.TrimEnd(" test", StringComparison.Ordinal, 1);
            string trimmed2 = sample.TrimEndOnce(" test", StringComparison.Ordinal);

            Assert.AreEqual(trimmed1, "test test");
            Assert.AreEqual(trimmed2, trimmed1);
        }
    }
}
