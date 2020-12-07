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
            var n = int.Parse(Console.ReadLine());
            var inputs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                inputs.Add(int.Parse(Console.ReadLine()));
            }
            
            Console.WriteLine(inputs.Count(num => isPrime(num) == true));
        }

        static bool isPrime(int n)
        {
            if (n == 2) return true;
            else if (n < 2 || n % 2 == 0) return false;

            var sq = Math.Sqrt(n);
            for (int i = 3; i <= sq; i+=2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
