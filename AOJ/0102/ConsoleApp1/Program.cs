
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

                var list = new int[n,n+1];

                for (int i = 0; i < n; i++)
                {
                    int[] inputs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < n; j++)
                    {
                        list[i, j] = inputs[j];
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    var sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(list[i, j].ToString().PadLeft(5));
                        sum += list[i, j];
                    }
                    list[i, n] = sum;
                    Console.WriteLine(sum.ToString().PadLeft(5));
                }

                for (int j = 0; j < n+1; j++)
                {
                    var sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += list[i, j];
                    }
                    Console.Write(sum.ToString().PadLeft(5));
                }
                Console.WriteLine("");

            }
        }

        public static int BitCount(int x) { x -= (x >> 1) & 0x55555555; x = (x & 0x33333333) + ((x >> 2) & 0x33333333); x = (x + (x >> 4)) & 0x0f0f0f0f; x += x >> 8; x += x >> 16; return x & 0x3f; }
        public static int BitCount(long x) { x -= (x >> 1) & 0x5555555555555555; x = (x & 0x3333333333333333) + ((x >> 2) & 0x3333333333333333); x = (x + (x >> 4)) & 0x0f0f0f0f0f0f0f0f; x += x >> 8; x += x >> 16; x += x >> 32; return (int)(x & 0x0000007f); }
    }
}
