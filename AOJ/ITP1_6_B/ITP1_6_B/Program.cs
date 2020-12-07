using System;
using System.Collections.Generic;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var map = new Dictionary<string, bool>();
            for (int i = 1; i <= 13; i++) map.Add("S " + i, false);
            for (int i = 1; i <= 13; i++) map.Add("H " + i, false);
            for (int i = 1; i <= 13; i++) map.Add("C " + i, false);
            for (int i = 1; i <= 13; i++) map.Add("D " + i, false);
            
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                map[input] = true;
            }

            map.Where((s, index) => s.Value == false)
                .Select(s => s.Key)
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
