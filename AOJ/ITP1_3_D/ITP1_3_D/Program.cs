using System;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var count = 0;

            for (int i = inputs[0]; i <= inputs[1]; i++)
            {
                if (inputs[2] % i == 0) count++;
            }

            Console.WriteLine(count);
        }
    }
}
