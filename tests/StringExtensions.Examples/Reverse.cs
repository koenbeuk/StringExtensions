using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class ReverseExample
    {
        [TestMethod]
        public void Example1()
        {
            // reverse a simple sample string
            string sample = "test";

            string reversedSample = sample.Reverse();

            Assert.AreEqual("tset", reversedSample);
        }
    }
}
