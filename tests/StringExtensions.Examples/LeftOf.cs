using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class LeftOfExample
    {
        [TestMethod]
        public void Example1()
        {
            // getting the name part of an email address
            string sample = "sample@domain.com";

            string namePart = sample.LeftOf('@');

            Assert.AreEqual("sample", namePart);
        }

        [TestMethod]
        public void Example2()
        {
            // getting a file filename without the last extension
            string sample = "sample.tar.gz";

            // skip the first match
            string fileName = sample.LeftOf('.', 1);

            Assert.AreEqual("sample.tar", fileName);
        }
    }
}
