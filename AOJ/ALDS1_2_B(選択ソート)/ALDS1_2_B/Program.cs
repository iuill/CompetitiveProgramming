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

            var count=0;
            for (int i = 0; i < n-1; i++)
            {
                var min = i;
                for (int j = i; j < n; j++)
                {
                    if (inputs[min] > inputs[j])
                    {
                        min = j;
                    }
                }
                if (i!=min)
                {
                    var t = inputs[min];
                    inputs[min] = inputs[i];
                    inputs[i] = t;

                    count++;
                }
            }

            Console.WriteLine(string.Join(" ",inputs.Select(s=>s.ToString()).ToArray<string>()));
            Console.WriteLine(count);
        }
    }
}
