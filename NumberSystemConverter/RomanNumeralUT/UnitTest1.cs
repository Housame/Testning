using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystemConverter;

namespace RomanNumeralUT
{
    [TestClass]
    public class UnitTest1
    {
        RomanNumeralConverter converter = new RomanNumeralConverter();
        [TestMethod]
        public void TestOutput50()
        {
            string exceptedOutput = "L";
            string actualOutput = converter.ConvertToRomanNumeral(50);
            Assert.AreEqual(exceptedOutput, actualOutput); 
        }
        [TestMethod]
        public void TestOutput100()
        {
            string exceptedOutput = "C";
            string actualOutput = converter.ConvertToRomanNumeral(100);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
        [TestMethod]
        public void TestOutput423()
        {
            string exceptedOutput = "CDXXIII";
            string actualOutput = converter.ConvertToRomanNumeral(423);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
        [TestMethod]
        public void TestOutput36()
        {
            string exceptedOutput = "XXXVI";
            string actualOutput = converter.ConvertToRomanNumeral(36);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
        [TestMethod]
        public void TestOutput924()
        {
            string exceptedOutput = "CMXXIV";
            string actualOutput = converter.ConvertToRomanNumeral(924);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
        [TestMethod]
        public void TestOutput21()
        {
            string exceptedOutput = "XXI";
            string actualOutput = converter.ConvertToRomanNumeral(21);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
        [TestMethod]
        public void TestOutput4()
        {
            string exceptedOutput = "IV";
            string actualOutput = converter.ConvertToRomanNumeral(4);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOutput_InvalidOperationException()
        {           
            string actualOutput = converter.ConvertToRomanNumeral(-1);
            Assert.Fail("Expected exception not thrown");
        }
        [TestMethod]
        public void TestOutput499()
        {
            string exceptedOutput = "CDXCIX";
            string actualOutput = converter.ConvertToRomanNumeral(499);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
        [TestMethod]
        public void TestOutput60()
        {
            string exceptedOutput = "LX";
            string actualOutput = converter.ConvertToRomanNumeral(60);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
        [TestMethod]
        public void TestOutput444()
        {
            string exceptedOutput = "CDXLIV";
            string actualOutput = converter.ConvertToRomanNumeral(444);
            Assert.AreEqual(exceptedOutput, actualOutput);
        }
    }
}
