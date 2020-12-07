
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
            int N = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];
            int[] B = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int[] A = new int[B.Length + 1];

            for (int i = 0; i < B.Length; i++)
            {
                if (i==0)
                {
                    A[i] = B[i];
                }
                if (A[i]>B[i])
                {
                    A[i] = B[i];
                }
                A[i + 1] = B[i];
            }

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(A.Sum());
            Console.Out.Flush();
        }
    }

}
