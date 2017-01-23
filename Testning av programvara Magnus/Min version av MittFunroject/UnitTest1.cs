using System;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_One_Divided_By_two()
        {
            var unitTestConsole = new ClassInput();
            var excepted = 0.5;
            var actual = unitTestConsole.MyDiv(2);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_Input_Is_String_Five()
        {
            var unitTestConsole = new ClassInput();
            var excepted = 2;
            var actual = unitTestConsole.Converter("2");
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_One_Divided_By_Zero()
        {
            var unitTestConsole = new ClassInput();
            var excepted = 0;
            var actual = unitTestConsole.MyDiv(0);
            Assert.AreEqual(excepted, actual);
        }
    }
}
