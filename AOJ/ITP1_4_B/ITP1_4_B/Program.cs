using System;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f6} {1:f6}", n*n*Math.PI, 2*n*Math.PI);
        }
    }
}
