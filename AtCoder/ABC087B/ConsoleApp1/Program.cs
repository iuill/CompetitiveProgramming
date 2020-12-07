
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
            long A = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray()[0];
            long B = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray()[0];
            long C = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray()[0];
            long X = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray()[0];

            var count = 0;
            for (int countA = 0; countA < A+1; countA++)
            {
                for (int countB = 0; countB < B+1; countB++)
                {
                    for (int countC = 0; countC < C+1; countC++)
                    {
                        if (X == (countA * 500) + (countB * 100) + (countC * 50))
                        {
                            count++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(count);
            Console.Out.Flush();
        }
    }

}
