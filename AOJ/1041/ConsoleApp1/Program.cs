
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
                var n = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];
                var sum = 0;

                if (n==0)
                    return;

                for (int i = 0; i < n / 4; i++)
                {
                    sum += Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];
                }

                Console.WriteLine(sum);
            }

        }

        public static int BitCount(int x) { x -= (x >> 1) & 0x55555555; x = (x & 0x33333333) + ((x >> 2) & 0x33333333); x = (x + (x >> 4)) & 0x0f0f0f0f; x += x >> 8; x += x >> 16; return x & 0x3f; }
        public static int BitCount(long x) { x -= (x >> 1) & 0x5555555555555555; x = (x & 0x3333333333333333) + ((x >> 2) & 0x3333333333333333); x = (x + (x >> 4)) & 0x0f0f0f0f0f0f0f0f; x += x >> 8; x += x >> 16; x += x >> 32; return (int)(x & 0x0000007f); }
    }
}
