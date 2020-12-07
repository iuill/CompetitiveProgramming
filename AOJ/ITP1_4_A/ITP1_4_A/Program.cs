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
            
            Console.WriteLine("{0} {1} {2:0.00000}",inputs[0]/inputs[1], inputs[0]%inputs[1], (double)inputs[0]/(double)inputs[1]);
        }
    }
}
