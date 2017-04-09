using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Examples
{
    [TestClass]
    [TestCategory("Examples")]
    public class AllBetweenExample
    {
        [TestMethod]
        public void Example1()
        {
            // This sample simply gets data surrounded by stars
            string sample = "i *am* surrounded and so am *i*";

            IEnumerable<string> quotedParts = sample.AllBetween('*');

            CollectionAssert.AreEqual(new[] { "am", "i" }, quotedParts.ToArray());
        }

        [TestMethod]
        public void Example2()
        {
            // this sample gets data surrounded by block quotes (2 different signs)
            string sample = "Look [i] am surrounded just [like] you";

            IEnumerable<string> quotedParts = sample.AllBetween('[', ']');

            CollectionAssert.AreEqual(new[] { "i", "like" }, quotedParts.ToArray());
        }
    }
}
