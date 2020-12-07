
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

            int[] inputs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            inputs = inputs.OrderByDescending(v => v).ToArray();

            var alice = inputs.Where((v, index) => index % 2 == 0).Sum();
            var bob = inputs.Where((v, index) => index % 2 != 0).Sum();

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(alice-bob);
            Console.Out.Flush();
        }
    }

}
