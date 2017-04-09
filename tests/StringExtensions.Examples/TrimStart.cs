using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class TrimStartExample
    {
        [TestMethod]
        public void Example1()
        {
            // Simply trim a prefix from the sample
            string sample = "my test";

            string trimmed = sample.TrimStart("my ", StringComparison.Ordinal);

            Assert.AreEqual(trimmed, "test");
        }

        [TestMethod]
        public void Example2()
        {
            // Trim only the first instance from the sample
            string sample = "test test test";

            string trimmed1 = sample.TrimStart("test ", StringComparison.Ordinal, 1);
            string trimmed2 = sample.TrimStartOnce("test ", StringComparison.Ordinal);

            Assert.AreEqual(trimmed1, "test test");
            Assert.AreEqual(trimmed2, trimmed1);
        }
    }
}
