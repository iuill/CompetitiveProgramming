
using System;
using System.Linq;
//using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = Console.ReadLine().Trim();

            //Regex r = new Regex("^(dream|dreamer|erase|eraser)+$");
            Regex r = new Regex("^(dream|dreamer|erase|eraser)+$", RegexOptions.Compiled);

            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.Out.Write(r.IsMatch(line) ? "YES":"NO");
            Console.Out.Flush();
        }
    }
}
