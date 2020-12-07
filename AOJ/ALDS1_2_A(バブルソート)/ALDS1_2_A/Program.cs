using System;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var count = 0;
            var lastindex = n-1;

            while (lastindex > 0)
            {
                for (int i = 0; i < lastindex; i++)
                {
                    if (inputs[i] > inputs[i + 1])
                    {
                        var t = inputs[i];
                        inputs[i] = inputs[i + 1];
                        inputs[i + 1] = t;

                        count++;
                    }
                }

                lastindex--;
            }

            Console.WriteLine(string.Join(" ", inputs.Select(s => s.ToString()).ToArray<string>()));
            Console.WriteLine(count);
        }
    }
}
