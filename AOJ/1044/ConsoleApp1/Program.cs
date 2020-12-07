
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
            var r = new Regex("^(?<first>[a-z]*)(?<second>[A-Z][a-z]*)*$", RegexOptions.Compiled);
            while (true)
            {
                var inputs = Console.ReadLine().Trim().Split();
                var str = inputs[0];
                var t = inputs[1];

                if (t=="X")
                {
                    return;
                }

                var splitted = str.Split('_').ToList();
                if (splitted.Count()<=1)
                {
                    splitted.Clear();
                    var gps = r.Match(str).Groups;

                    var first = gps["first"].Value;
                    if (first.Length>0)//先頭大文字だと空文字列になる
                    {
                        splitted.Add(first);
                    }
                    foreach (Capture cap in gps["second"].Captures)
                    {
                        splitted.Add(cap.Value.ToLower());
                    }
                }

                switch (t)
                {
                    case "U":
                    case "L":
                        {
                            for (int i = 0; i < splitted.Count(); i++)
                            {
                                var s = splitted[i];
                                var tartget = "";

                                if (i==0 && t=="L")
                                {
                                    tartget += s[0];
                                }
                                else
                                {
                                    tartget += s[0].ToString().ToUpper();
                                }
                                if (s.Length > 1)
                                {
                                    //tartget += s[1..]; //Monoが対応していない
                                    tartget += s.Substring(1);
                                }
                                Console.Write(tartget);
                            }
                        }
                        break;
                    case "D":
                        {
                            Console.Write(string.Join("_", splitted));
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("");
            }

        }
    }
}
