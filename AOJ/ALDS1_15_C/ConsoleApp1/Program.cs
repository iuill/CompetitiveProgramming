using System;
using System.Collections;
//using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class P
    {
        public long Start { get; set; }
        public long End { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine().Trim());
            var arr = new P[n];

            for (int i = 0; i < n; i++)
            {
                var inputs = Console.ReadLine().Trim().Split().Select(long.Parse).ToArray();
                arr[i] = new P() { Start = inputs[0], End = inputs[1] };
            }

            var sorted = arr.OrderBy(a => a.End).ThenBy(a => a.Start);

            var latest = sorted.First();
            var count = 1;
            foreach (var item in sorted)
            {
                if (latest.End < item.Start)
                {
                    latest = item;
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
