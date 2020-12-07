using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodByFilename()
        {
            TestInOut("01_i.txt", "01_o.txt");
        }

        [TestMethod]
        public void TestMethodByCaseNumber()
        {
            TestInOutByCaseNumber("01");
        }


        public void TestInOutByCaseNumber(string caseNumber)
        {
            const string dir = "TestCase\\";
            var inputFileName = dir + caseNumber + "_i.txt";
            var outputFileName = dir + caseNumber + "_o.txt";

            using (var input = new StreamReader(inputFileName))
            using (var output = new StringWriter())
            {
                Console.SetOut(output);
                Console.SetIn(input);

                Program.Main(new string[0]);

                Assert.AreEqual(File.ReadAllText(outputFileName), output.ToString());
            }
        }

        public void TestInOut(string inputFileName, string outputFileName)
        {
            const string dir = "TestCase\\";
            using (var input = new StreamReader(dir + inputFileName))
            using (var output = new StringWriter())
            {
                Console.SetOut(output);
                Console.SetIn(input);

                Program.Main(new string[0]);

                Assert.AreEqual(File.ReadAllText(dir + outputFileName), output.ToString());
            }
        }
    }
}
