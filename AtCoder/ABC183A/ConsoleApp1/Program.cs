
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
            int x = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];

            var ReLU = x >= 0 ? x : 0;

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(ReLU);
            Console.Out.Flush();
        }
    }
}
