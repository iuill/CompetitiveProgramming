using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(inputs.Min() + " " + inputs.Max());
        }
    }
}
