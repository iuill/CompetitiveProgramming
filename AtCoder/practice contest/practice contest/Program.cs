using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yukicoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var bc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var s = Console.ReadLine();

            Console.WriteLine("{0} {1}", a + bc[0] + bc[1], s);
        }
    }
}
