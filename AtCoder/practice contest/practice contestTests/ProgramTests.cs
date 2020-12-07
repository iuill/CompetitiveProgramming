using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace yukicoder.unitTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            TestInOut("Sample1.txt");
            TestInOut("Sample2.txt");
        }


        public void TestInOut(string fileName)
        {
            TestInOut(fileName, fileName);
        }

        public void TestInOut(string inputFileName, string outputFileName)
        {
            inputFileName = "./Input/" + inputFileName;
            outputFileName = "./Output/" + outputFileName;

            using (var input = new System.IO.StreamReader(inputFileName))
            using (var output = new System.IO.StringWriter())
            {
                Console.SetOut(output);
                Console.SetIn(input);

                Program.Main(new string[0]);

                Assert.AreEqual(
                    System.IO.File.ReadAllText(outputFileName).Replace("\r\n", "\n"),
                    output.ToString().Replace("\r\n", "\n")
                );
            }
        }
    }
}