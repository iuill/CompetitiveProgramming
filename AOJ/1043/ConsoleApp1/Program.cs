
using System;
using System.Linq;
//using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class P
    {
        public int teamId { get; set; }
        public int affiliated { get; set; }
        public int answers { get; set; }
        public int penalty { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var list = new List<P>();

                var n = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];
                if (n == 0)
                    return;

                for (int i = 0; i < n; i++)
                {
                    int[] inputs = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
                    list.Add(new P() { teamId = inputs[0], affiliated = inputs[1], answers = inputs[2], penalty = inputs[3] });
                }

                var sorted = list
                    .OrderByDescending(v => v.answers)
                    .ThenBy(v => v.penalty)
                    .ThenBy(v => v.teamId);

                var map = new Dictionary<int, int>();
                var selectedCount = 0;
                foreach (var v in sorted)
                {
                    if (!map.ContainsKey(v.affiliated))
                    {
                        map.Add(v.affiliated, 0);
                    }

                    var affiSelected = map[v.affiliated];
                    if (selectedCount < 10)
                    {
                        if (affiSelected < 3)
                        {
                            map[v.affiliated] = ++affiSelected;
                            selectedCount++;
                            Console.WriteLine(v.teamId);
                        }
                    }
                    else if (selectedCount < 20)
                    {
                        if (affiSelected < 2)
                        {
                            map[v.affiliated] = ++affiSelected;
                            selectedCount++;
                            Console.WriteLine(v.teamId);
                        }
                    }
                    else if (selectedCount < 26)
                    {
                        if (affiSelected < 1)
                        {
                            map[v.affiliated] = ++affiSelected;
                            selectedCount++;
                            Console.WriteLine(v.teamId);
                        }
                    }
                }
            }
        }

        public static int BitCount(int x) { x -= (x >> 1) & 0x55555555; x = (x & 0x33333333) + ((x >> 2) & 0x33333333); x = (x + (x >> 4)) & 0x0f0f0f0f; x += x >> 8; x += x >> 16; return x & 0x3f; }
        public static int BitCount(long x) { x -= (x >> 1) & 0x5555555555555555; x = (x & 0x3333333333333333) + ((x >> 2) & 0x3333333333333333); x = (x + (x >> 4)) & 0x0f0f0f0f0f0f0f0f; x += x >> 8; x += x >> 16; x += x >> 32; return (int)(x & 0x0000007f); }
    }
}
