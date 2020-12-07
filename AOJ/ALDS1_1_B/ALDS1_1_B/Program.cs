using System;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var x = inputs[0];
            var y = inputs[1];
            
            var min = Math.Min(x, y);
            var max = Math.Max(x,y);
            var mod = max%min;
            while(mod != 0)
            {
                max = Math.Max(min, mod);
                min = Math.Min(min, mod);
                mod = max % min;
            }

            Console.WriteLine(min);
        }
    }
}
