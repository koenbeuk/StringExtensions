using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class ConvertExample
    {
        [TestMethod]
        public void Example1()
        {
            string sample = "test";

            string converted = sample.Convert(Encoding.UTF8);
            string convertedBack = sample.Convert(Encoding.Unicode, Encoding.UTF8);

            Assert.AreEqual(convertedBack, sample);
        }
    }
}
