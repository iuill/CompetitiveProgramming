
using System;
using System.Linq;
//using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class P
    {
        public long A { get; set; }
        public long B { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            long[] inputs = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray();

            long n = inputs[0] * inputs[1];


            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(n%2==0?"Even":"Odd");
            Console.Out.Flush();
        }
    }

}
