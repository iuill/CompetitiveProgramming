using System;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();


            Console.WriteLine("{0} {1}", inputs[0] * inputs[1], inputs.Sum() * 2);
            Console.Out.Flush();
        }
    }
}
