using System;
using System.Collections.Generic;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(i, int.Parse(Console.ReadLine()));
            }

            var min = list[0];
            var max = int.MinValue;

            for (int i = 1; i < n; i++)
            {
                max = max > (list[i] - min) ? max : list[i] - min;
                min = min < list[i] ? min : list[i];
            }

            Console.WriteLine(max);
        }
    }
}
