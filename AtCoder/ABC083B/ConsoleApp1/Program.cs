
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
            long N = inputs[0];
            long A = inputs[1];
            long B = inputs[2];

            long result = 0;
            for (long i = 1; i <= N; i++)
            {
                var s = i.ToString();
                var sum = s.Select(c => int.Parse("" + c)).Sum();
                if (A <= sum && sum <= B)
                {
                    result += i;
                }
            }

            

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(result);
            Console.Out.Flush();
        }
    }

}
