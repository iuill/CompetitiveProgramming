using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToList();
            inputs.Sort();
            Console.WriteLine(string.Join(" ", inputs.Select(n => n.ToString()).ToArray()));
        }
    }
}
