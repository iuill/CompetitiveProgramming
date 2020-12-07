using System;
using System.Collections.Generic;
using System.Linq;

namespace yukicoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = inputs[0];
            var q = inputs[1];

            var list = Enumerable.Range(0, n).Select(a => (char)('A' + a)).ToList();

            var q_counter = 0;

            var history = new Dictionary<string, string>();

            while(true)
            {
                var complete = true;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    string r;
                    var query = string.Format("? {0} {1}", list[i], list[i + 1]);
                    if(!history.ContainsKey(query))
                    {
                        Console.WriteLine(query);
                        Console.Out.Flush();
                        q_counter++;

                        r = Console.ReadLine();
                        history.Add(query, r);
                    }
                    else
                    {
                        r = history[query];
                    }

                    if (r == ">")
                    {
                        var tmp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = tmp;
                        complete = false;
                    }

                    if (q_counter >= q) break;
                }

                if (complete) break;
            }

            Console.WriteLine("! " + string.Join("",list));
            Console.Out.Flush();
        }
    }
}
