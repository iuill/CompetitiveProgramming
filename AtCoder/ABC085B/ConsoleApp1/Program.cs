
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
            var N = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];
            var list = new List<int>();
            for (int i = 0; i < N; i++)
            {
                var tmp = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];
                list.Add(tmp);
            }

            var count = list.Distinct().Count();

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(count);
            Console.Out.Flush();
        }
    }

}
