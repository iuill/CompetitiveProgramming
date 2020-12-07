using System;

namespace procon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dt = new DateTime(2000, 1, 1).AddSeconds(n);
            
            Console.WriteLine("{0}:{1}:{2}",dt.Hour, dt.Minute, dt.Second);
        }
    }
}
