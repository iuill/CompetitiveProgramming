
using System;
using System.Linq;
//using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            int[] inputsA = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            Console.ReadLine();
            int[] inputsB = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            int result = 0;
            for (int i = 0; i < Math.Max(inputsA.Length, inputsB.Length); i++)
            {
                var a = i >= inputsA.Length ? -1 : inputsA[i];
                var b = i >= inputsB.Length ? -1 : inputsB[i];

                var tmp = a-b;
                if (tmp > 0)
                {
                    break;
                }
                else if (tmp < 0)
                {
                    result = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.WriteLine(result);
            Console.Out.Flush();
        }
    }

}
