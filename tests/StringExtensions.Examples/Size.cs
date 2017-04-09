using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class SizeExample
    {
        [TestMethod]
        public void Example1()
        {
            string sample = "test";

            int size = sample.Size();

            Assert.AreEqual(size, 8);
        }

        [TestMethod]
        public void Example2()
        {
            string sample = "test"; 

            int size = sample.Size(Encoding.ASCII);

            Assert.AreEqual(size, 4);
        }
    }
}
