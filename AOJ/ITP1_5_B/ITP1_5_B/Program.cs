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
            while (true)
            {
                var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (inputs[0] == 0 && inputs[1] == 0) break;

                for (int j = 0; j < inputs[0]; j++)
                {
                    string str;
                    if (j == 0 || j == inputs[0] - 1)
                    {
                        str = new string('#', inputs[1]);
                    }
                    else
                    {
                        str = "#" + new string('.', inputs[1] - 2) + "#";
                    }

                    Console.WriteLine(str);
                }

                Console.WriteLine();
            }
        }
    }
}
