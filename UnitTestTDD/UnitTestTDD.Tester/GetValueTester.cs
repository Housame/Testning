using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestLibrary;
//TODO 1. Change class name from Class1 to GetValueTester
//TODO 2. Change class file name from Class1.cs to GetValueTester.cs
//TODO 3. Add reference UnitTestLibrary TO unit test project
//TODO 4. Through NuGet, install NUnit 3 to this project. Add using NUnit.Framework
//TODO 5. Istall NUnit Adapter from Tools-Extensions and Updates
//TODO 6. Add [TestFixture] to class 
//TODO 7. Add Testcase named Converter_From_Int_1_To_String1()
//TODO 8. Add [Test] to method

namespace UnitTestTDD.Tester
{
    [TestFixture]
    public class GetValueTester
    {
        [Test]
        public void Converter_From_Int_1_To_String1()
        {
            // Arrange (Prepare test case with the attributes required)
            int input = 1;
            string expectedOutput = "1";

            // Act (Perform the test case and get the actualOutput)
            Converter converter = new Converter();
            string actualOutput = converter.ConvertIntToString(input);
                Assert.AreEqual(expectedOutput, actualOutput);

        }
    }
}
