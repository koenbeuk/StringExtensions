using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class RightOfExample
    {
        [TestMethod]
        public void Example1()
        {
            // getting the domain part of an email address
            string sample = "sample@domain.com";

            string namePart = sample.RightOf('@');

            Assert.AreEqual("domain.com", namePart);
        }

        [TestMethod]
        public void Example2()
        {
            // getting the full extension 
            string sample = "sample.tar.gz";

            // skip the first match
            string fileName = sample.RightOf('.', 1);

            Assert.AreEqual("tar.gz", fileName);
        }

        [TestMethod]
        public void Example3()
        {
            string sample = "sample.tar.gz";

            var extension = sample.RightOf("sample");

            Assert.AreEqual(".tar.gz", extension);
        }

        [TestMethod]
        public void Example4()
        {
            string sample = "sample.tar.gz";

            var extension = sample.RightOf(".", 1, StringComparison.Ordinal);

            Assert.AreEqual("gz", extension);
        }
    }
}
