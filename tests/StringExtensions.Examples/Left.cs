using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class LeftExample
    {
        [TestMethod]
        public void Example1()
        {
            // getting the name part of an email address
            string sample = "sample@domain.com";

            string namePart = sample.Left(6);

            Assert.AreEqual("sample", namePart);
        }
    }
}
