using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace procon.unitTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            TestInOut("Sample1.txt");
            TestInOut("Sample2.txt");
            TestInOut("Sample3.txt");
            //TestInOut("Sample4.txt");
            //TestInOut("test10.txt");
            //TestInOut("test100.txt");
            //TestInOut("1.txt");
            //TestInOut("2.txt");
            //TestInOut("3.txt");
            //TestInOut("4.txt");
            //TestInOut("5.txt");
            //TestInOut("6.txt");
            //TestInOut("7.txt");
            //TestInOut("8.txt");
            //TestInOut("9.txt");
            //TestInOut("01.txt");
            //TestInOut("02.txt");
            //TestInOut("03.txt");
            //TestInOut("04.txt");
            //TestInOut("05.txt");
            //TestInOut("06.txt");
            //TestInOut("07.txt");
            //TestInOut("08.txt");
            //TestInOut("09.txt");
            //TestInOut("10.txt");
            //TestInOut("11.txt");
            //TestInOut("12.txt");
            //TestInOut("13.txt");
            //TestInOut("14.txt");
            //TestInOut("15.txt");
            //TestInOut("16.txt");
            //TestInOut("17.txt");
            //TestInOut("18.txt");
            //TestInOut("19.txt");
            //TestInOut("20.txt");
            //TestInOut("challenge01.txt");
            //TestInOut("challenge02.txt");
            //TestInOut("challenge03.txt");
            //TestInOut("challenge04.txt");
            //TestInOut("challenge05.txt");
            //TestInOut("challenge06.txt");
            //TestInOut("challenge07.txt");
            //TestInOut("challenge08.txt");
            //TestInOut("system_test1.txt");
            //TestInOut("system_test2.txt");
            //TestInOut("system_test3.txt");
            //TestInOut("system_test4.txt");
            //TestInOut("system_test5.txt");
            //TestInOut("system_test6.txt");
            //TestInOut("system_test7.txt");
            //TestInOut("system_test8.txt");
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