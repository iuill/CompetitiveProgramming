using System;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(inputs[0] < inputs[1] && inputs[1] < inputs[2] ? "Yes" : "No");
        }
    }
}
