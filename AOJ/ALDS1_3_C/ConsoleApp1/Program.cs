using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine().Trim());

            var list = new System.Collections.Generic.LinkedList<string>();

            for (int i = 0; i < n; i++)
            {
                var args = Console.ReadLine().Trim().Split(' ');
                var cmd = args[0];
                var key = string.Empty;
                if (args.Length == 2)
                {
                    key = args[1];
                }


                switch (cmd)
                {
                    case "insert":
                        list.AddFirst(key);
                        break;
                    case "delete":
                        list.Remove(key);
                        break;
                    case "deleteFirst":
                        list.RemoveFirst();
                        break;
                    case "deleteLast":
                        list.RemoveLast();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
