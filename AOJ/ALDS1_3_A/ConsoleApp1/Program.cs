using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var stack = new System.Collections.Generic.Stack<int>();
            var args = Console.ReadLine().Trim().Split(' ');

            foreach (var s in args)
            {
                if(System.Text.RegularExpressions.Regex.IsMatch(s, "\\d"))
                {
                    stack.Push(int.Parse(s));
                }
                else
                {
                    var b = stack.Pop();
                    var a = stack.Pop();

                    switch (s)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(a - b);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
