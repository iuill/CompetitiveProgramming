using System;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());

            Console.WriteLine(x*x*x);
            Console.Out.Flush();
        }
    }
}
