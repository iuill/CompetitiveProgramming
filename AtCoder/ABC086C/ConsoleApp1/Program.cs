
using System;
using System.Linq;
//using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class P
    {
        public int T { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int N = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];
            var list = new List<P>();

            for (int i = 0; i < N; i++)
            {
                int[] inputs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                list.Add(new P() { T = inputs[0], X = inputs[1], Y = inputs[2] });
            }

            var sorted = list.OrderBy(o => o.T); //特に記載ないので念の為ソートしておく

            P prev = new P() { T = 0, X = 0, Y = 0 };
            bool isFailed = false;

            foreach (var item in sorted)
            {
                var diffT = item.T - prev.T;
                var diffX = Math.Abs(item.X - prev.X);
                var diffY = Math.Abs(item.Y - prev.Y);
                var diffXY = diffX + diffY;

                if (diffXY > diffT)
                {
                    isFailed = true;
                    break;
                }
                if ((diffT - diffXY) % 2 != 0)
                {
                    isFailed = true;
                    break;
                }

                prev = item;
            }

            /* --output-- */
            //Console.WriteLine("hello = {0} , world = {1}", inputs[0], inputs[1]);
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(isFailed?"No":"Yes");
            Console.Out.Flush();
        }
    }
}
