using System;
using System.Linq;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i < N; i++)
            {
                Console.WriteLine(string.Join(" ", A.Select(n => n.ToString()).ToArray<string>()));

                var v = A[i];
                var j = i - 1;

                while (j>=0 && A[j]>v)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = v;
            }
            Console.WriteLine(string.Join(" ", A.Select(n => n.ToString()).ToArray<string>()));
        }
    }
}
