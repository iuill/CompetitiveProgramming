using System;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var W = inputs[0];
            var H = inputs[1];
            var x = inputs[2];
            var y = inputs[3];
            var r = inputs[4];

            // 範囲ならtrue
            var left = r <= x;
            var right = x + r <= W;
            var top = y + r <= H;
            var bottom = r <= y;

            Console.WriteLine(left && right && top && bottom ? "Yes" : "No");
        }
    }
}
