using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class ReplaceExample
    {
        [TestMethod]
        public void Example1()
        {
            // Replace now allows the specification of a StringComparison instance and therefore is able to match both characters
            string sample = "This is a sample containing CAPITALIZED content";

            string replaced = sample.Replace("capitalized", "fixed", StringComparison.OrdinalIgnoreCase);

            Assert.IsFalse(replaced.Contains("CAPITALIZED", StringComparison.Ordinal));
            Assert.IsTrue(replaced.Contains("fixed", StringComparison.Ordinal));
        }

        [TestMethod]
        public void Example2()
        {
            // Replace now allows the specification of a range and a result count of how many instances have been replaced
            string sample = "test test test test";

            int count;
            string replaced = sample.Replace("test", "replaced", 5, 10, StringComparison.Ordinal, out count);

            Assert.AreEqual(count, 2);
            Assert.AreEqual(replaced, "test replaced replaced test");
        }
    }
}
