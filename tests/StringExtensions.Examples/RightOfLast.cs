using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class RightOfLastExample
    {
        [TestMethod]
        public void Example1()
        {
            // getting the last extension of a fileName
            string sample = "sample.tar.gz";

            string fileName = sample.RightOfLast('.');

            Assert.AreEqual("gz", fileName);
        }
    }
}
