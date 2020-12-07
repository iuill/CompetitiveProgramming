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
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine("a {0} b", inputs[0]>inputs[1]?">":inputs[0]==inputs[1]?"==":"<");
        }
    }
}
