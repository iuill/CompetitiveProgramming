using System;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (inputs[0] == 0 && inputs[1] == 0) break;

                for (int i = 0; i < inputs[0]; i++)
                {
                    Console.WriteLine(new string('#', inputs[1]));
                }

                Console.WriteLine();
            }
        }
    }
}
