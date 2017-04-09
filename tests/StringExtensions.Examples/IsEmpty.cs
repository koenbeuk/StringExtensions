using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class IsEmptyExample
    {
        [TestMethod]
        public void Example1()
        {
            // isEmpty for an empty string should return true
            string sample = "";

            bool isEmpty = sample.IsEmpty();

            Assert.AreEqual(isEmpty, true);
        }

        [TestMethod]
        public void Example2()
        {
            // isEmpty for a non-empty string should return false
            string sample = "    "; // a string with spaces

            bool isEmpty = sample.IsEmpty();

            Assert.AreEqual(isEmpty, false);
        }
    }
}
