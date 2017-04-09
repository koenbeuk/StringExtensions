using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class IsEmptyOrWhiteSpaceExample
    {
        [TestMethod]
        public void Example1()
        {
            // isEmptyOrWhitespace for an empty string should return true
            string sample = "";

            bool isEmpty = sample.IsEmptyOrWhiteSpace();

            Assert.AreEqual(isEmpty, true);
        }

        [TestMethod]
        public void Example2()
        {
            // isEmptyOrWhitespace for a whitespace only string should return true
            string sample = "    "; // a string with spaces

            bool isEmpty = sample.IsEmptyOrWhiteSpace();

            Assert.AreEqual(isEmpty, true);
        }

        [TestMethod]
        public void Example3()
        {
            // isEmptyOrWhitespace for a string containing other characters should return false
            string sample = " hello! "; 

            bool isEmpty = sample.IsEmptyOrWhiteSpace();

            Assert.AreEqual(isEmpty, false);
        }
    }
}
