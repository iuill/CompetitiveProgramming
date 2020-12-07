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
            var n = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split();
            var inputs2 = new List<string>(inputs);

            // ↓いらなかったかも・・・
            var map = new Dictionary<int, List<string>>();
            Enumerable.Range(1, 9).ToList().ForEach(i => map.Add(i, new List<string>()));
            inputs
                .ToList()
                .ForEach(str =>
                {
                    var s = int.Parse(str.Substring(1, 1));
                    map[s].Add(str);
                }
                );

            // ↓数字だけとりだしての比較が必要
            BubbleSort(n, inputs);
            SelectionSort(n, inputs);
        }


        public static void BubbleSort(int n, string[] inputs)
        {
            for (var i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (inputs[j] < inputs[j - 1])
                    {
                        var t = inputs[j];
                        inputs[j] = inputs[j - 1];
                        inputs[j - 1] = t;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", inputs.Select(s => s.ToString()).ToArray<string>()));
            Console.WriteLine("Stable or Not Stable");
        }

        public static void SelectionSort(int n, string[] inputs)
        {
            for (int i = 0; i < n - 1; i++)
            {
                var min = i;
                for (int j = i; j < n; j++)
                {
                    if (inputs[min] > inputs[j])
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    var t = inputs[min];
                    inputs[min] = inputs[i];
                    inputs[i] = t;
                }
            }

            Console.WriteLine(string.Join(" ", inputs.Select(s => s.ToString()).ToArray<string>()));
            Console.WriteLine("Stable or Not Stable");
        }
    }
}
