using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class LeftOfLastExample
    {
        [TestMethod]
        public void Example1()
        {
            // getting a filename without the last extension
            string sample = "sample.tar.gz";

            string fileName = sample.LeftOfLast('.');

            Assert.AreEqual("sample.tar", fileName);
        }
    }
}
