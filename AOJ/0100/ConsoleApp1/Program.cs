
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
            while (true)
            {
                int n = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];

                if (n==0)
                {
                    return;
                }

                var list = new List<dynamic>();

                for (int i = 0; i < n; i++)
                {
                    int[] inputs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

                    list.Add(new { e = inputs[0], p = inputs[1], q = inputs[2] });
                }

                var result = list
                    .GroupBy(v => v.e)
                    .Select(v => new { e = v.Key, sum = v.Sum(vv => vv.p * vv.q) })
                    .Where(v => v.sum >= 1000000);

                if (result.Count() > 0)
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.e);
                    }
                }
                else
                {
                    Console.WriteLine("NA");
                }

            }
        }

        public static int BitCount(int x) { x -= (x >> 1) & 0x55555555; x = (x & 0x33333333) + ((x >> 2) & 0x33333333); x = (x + (x >> 4)) & 0x0f0f0f0f; x += x >> 8; x += x >> 16; return x & 0x3f; }
        public static int BitCount(long x) { x -= (x >> 1) & 0x5555555555555555; x = (x & 0x3333333333333333) + ((x >> 2) & 0x3333333333333333); x = (x + (x >> 4)) & 0x0f0f0f0f0f0f0f0f; x += x >> 8; x += x >> 16; x += x >> 32; return (int)(x & 0x0000007f); }
    }
}
