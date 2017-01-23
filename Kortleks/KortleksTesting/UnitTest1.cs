using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kortleks;

namespace KortleksTesting
{
    [TestClass]
    public class UnitTest1
    {
        Runtime runtime = new Runtime();
        [TestMethod]
        public void TestConverter_Two_spades()
        {
            string expectedOutput = "2 of Spades";
            string actualOutput = runtime.Converter("2S");
            Assert.AreEqual(expectedOutput,actualOutput);
        }
    }
}
