
using System;
using System.Linq;
//using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var map = new Dictionary<string, int>();
            //map.Add("(", 5);
            map.Add("/", 3);
            map.Add("*", 3);
            map.Add("+", 2);
            map.Add("-", 2);
            map.Add("=", 1);

            int n = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray()[0];
            var datasets = new List<string>();
            for (int i = 0; i < n; i++)
            {
                datasets.Add(Console.ReadLine());
            }
            foreach (var item in datasets)
            {
                // --------------------------------------------------------
                // 操車場アルゴリズムで中置記法を後置記法(RPN)に変換する
                // --------------------------------------------------------

                // 逆ポーランド法で格納された出力用数式ストリーム
                var queue = new Queue<string>();
                // 演算オペレータ用一時スタック
                var stack = new Stack<string>();

                // 値の取り出し時、複数桁の数値を考慮
                Regex r = new Regex("^(\\d+|\\D)+$", RegexOptions.Compiled);
                var ms = r.Match(item);
                var caps = ms.Groups[1].Captures;

                foreach(Capture cap in caps)
                {
                    //var token = item[i].ToString();
                    var token = cap.Value;
                    int num;

                    //if (int.TryParse(token, out _)) //破棄はC#7.0以降
                    if (int.TryParse(token, out num))
                    {
                        queue.Enqueue(token);
                    }
                    else if (token == "(")
                    {
                        stack.Push(token);
                    }
                    else if (token == ")")
                    {
                        while (stack.Count() > 0)
                        {
                            var peek = stack.Peek();
                            if (peek != "(")
                            {
                                queue.Enqueue(stack.Pop());
                            }
                            else
                            {
                                stack.Pop(); // "("はそのまま破棄
                                break;
                            }
                        }
                    }
                    else
                    {
                        var tokenN = map[token];
                        while (stack.Count()>0)
                        {
                            if (stack.Peek() == "(")
                            {
                                break;
                            }

                            var peekN = map[stack.Peek()];
                            if (tokenN <= peekN)
                            {
                                queue.Enqueue(stack.Pop());
                            }
                            else
                            {
                                break;
                            }
                        }
                        stack.Push(token);
                    }


                }

                // 逆ポーランド法で格納されたキューを処理

                var calc = new Stack<int?>();
                while (queue.Count()>0)
                {
                    var v = queue.Dequeue();
                    int num;

                    if (int.TryParse(v, out num))
                    {
                        calc.Push(num);
                    }
                    else
                    {
                        var b = calc.Pop();
                        var a = calc.Pop();

                        int? result=null;
                        switch (v)
                        {
                            case "*":
                                {
                                    result = a * b;
                                }
                                break;
                            case "/":
                                {
                                    result = a / b;
                                }
                                break;
                            case "+":
                                {
                                    result = a + b;
                                }
                                break;
                            case "-":
                                {
                                    result = a - b;
                                }
                                break;
                            default:
                                break;

                        }
                        calc.Push(result);
                    }
                }
                Console.WriteLine(calc.Pop());
            }
        }
    }
}