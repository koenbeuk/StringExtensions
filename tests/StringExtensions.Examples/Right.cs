using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class RightExample
    {
        [TestMethod]
        public void Example1()
        {
            // getting the domain part of an email address
            string sample = "sample@domain.com";

            string namePart = sample.Right(10);

            Assert.AreEqual("domain.com", namePart);
        }
    }
}
