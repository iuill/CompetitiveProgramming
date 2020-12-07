
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
            string line = Console.ReadLine().Trim();
            long n = line.Count(s => s == '1');

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(n);
            Console.Out.Flush();
        }
    }

}
