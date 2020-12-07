
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
            long a = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray()[0];
            long[] bc = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray();
            long b = bc[0];
            long c = bc[1];
            string s = Console.ReadLine().Trim();

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write((a+b+c) + " " + s);
            Console.Out.Flush();
        }
    }

}
