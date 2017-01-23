using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInputOutput;
using System.IO;

namespace TDDTest
{
    [TestClass]
    public class UnitTest1
    {
        Manager mgr = new Manager();
        [TestMethod]
        public void NameTester()
        {
            string expectedOutput = "Housame Oueslati";
            string actualOutput = mgr.NameInputer("Housame", "Oueslati");
            Assert.AreEqual(expectedOutput, actualOutput); 
        }
        [TestMethod]
        public void AdditionTester_10_5()
        {
            int expectedOutput = 15;
            int actualOutput = mgr.AdditionInputer(10, 5);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
       
        [TestMethod]
        public void SubtractionTester_28_5()
        {
            int expectedOutput = 23;
            int actualOutput = mgr.SubtractionInputer(28, 5);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void SubtractionTester_19_50()
        {
            int expectedOutput = -31;
            int actualOutput = mgr.SubtractionInputer(19, 50);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void MultiplicationTester_25_4()
        {
            int expectedOutput = 100;
            int actualOutput = mgr.MultiplicationInputer(25, 4);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void MultiplicationTester_999_0()
        {
            int expectedOutput = 0;
            int actualOutput = mgr.MultiplicationInputer(999, 0);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void MultiplicationTester_0_0()
        {
            int expectedOutput = 0;
            int actualOutput = mgr.MultiplicationInputer(0, 0);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void DivisionsTester_85_5()
        {
            int expectedOutput = 17;
            int actualOutput = mgr.DivisionsInputer(85, 5);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void DivisionsTester_0_1()
        {
            int expectedOutput = 0;
            int actualOutput = mgr.DivisionsInputer(0, 1);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void FileExistTest()
        {
            bool expectedOutput = true;
            bool actualOutput = mgr.FileChecker(@"C:\Users\acer pc\Desktop\Plugget\Testning av programvara\TDDInputOutput\Text.txt");
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void ReadFromFile_WriteToText()
        {
            string pathLocator = @"C: \Users\acer pc\Desktop\Plugget\Testning av programvara\TDDInputOutput\TestText.txt";
            File.WriteAllText(pathLocator, String.Empty);
            string expectedOutput = mgr.NameInputer("Housame", "Oueslati") + ", " + mgr.AdditionInputer(10, 5) + ", " + mgr.SubtractionInputer(25, 10) + ", " + mgr.MultiplicationInputer(5, 3) + ", " + mgr.DivisionsInputer(45, 3) + ";";
            mgr.WriteToTxt(expectedOutput, pathLocator);
            string actualOutput = File.ReadAllText(pathLocator).ToString();
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
