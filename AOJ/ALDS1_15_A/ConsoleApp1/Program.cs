using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine().Trim());
            var count = 0;
            var array = new int[] { 25, 10, 5,1 };

            foreach (var v in array)
            {
                if (n >= v)
                {
                    count += n / v;
                    n = n % v;
                }
            }

            Console.WriteLine(count);
        }
    }
}
