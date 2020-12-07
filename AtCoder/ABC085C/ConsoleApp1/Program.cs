
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
            int[] inputs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            int N = inputs[0];
            int Y = inputs[1];

            var result = "-1 -1 -1";
            for (int countMan = 0; countMan <= N; countMan++)
            {
                for (int countGosen = 0; countGosen <= (N - countMan); countGosen++)
                {
                    var countSen = N - countMan - countGosen;
                    if (Y == (countMan * 10000 + countGosen * 5000 + countSen * 1000))
                    {
                        result = countMan + " " + countGosen + " " + countSen;
                        goto RESULT;
                    }
                }
            }

        RESULT:
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(result);
            Console.Out.Flush();
        }
    }

}
