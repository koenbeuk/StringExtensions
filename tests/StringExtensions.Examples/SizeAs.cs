using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class SizeAsExample
    {
        [TestMethod]
        public void Example1()
        {
            string sample = "test";

            int size = sample.SizeAs(Encoding.UTF8);

            Assert.AreEqual(size, 4);
        }

        [TestMethod]
        public void Example2()
        {
            string sample = "test"; 

            int size = sample.SizeAs(Encoding.ASCII, Encoding.Unicode);

            Assert.AreEqual(size, 4);
        }
    }
}
