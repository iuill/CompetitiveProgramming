
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
            long n = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray()[0];
            long[] inputs = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray();

            var count = 0;
            while (true)
            {
                if (!inputs.All(v => v % 2 == 0))
                {
                    break;
                }
                inputs = inputs.Select(v => v / 2).ToArray();
                count++;
            }


            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(count);
            Console.Out.Flush();

        }
    }

}
