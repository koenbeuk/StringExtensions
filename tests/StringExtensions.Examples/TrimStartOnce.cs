using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class TrimStartOnceExample
    {
        [TestMethod]
        public void Example1()
        {
            // Simply trim a prefix from the sample
            string sample = "test test test";

            string trimmed = sample.TrimStartOnce("test ", StringComparison.Ordinal);

            Assert.AreEqual(trimmed, "test test");
        }
    }
}
