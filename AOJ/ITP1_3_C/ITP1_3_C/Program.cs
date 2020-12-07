using System;
using System.Collections.Generic;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int[]>();
            while (true)
            {
                var tmp = Console.ReadLine().Split().Select(int.Parse).ToList();
                if (tmp[0] == 0 && tmp[1] == 0) break;

                list.Add(tmp.OrderBy(s => s).ToArray());
            }

            foreach (var item in list)
            {
                Console.WriteLine("{0} {1}", item[0], item[1]);
            }
        }
    }
}
