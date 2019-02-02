using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitter = { ' ', '=', '\'', };
            string[] input = Console.ReadLine()
                .Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            IPLogger(input);
        }

        static void IPLogger(string[] input)
        {
            SortedDictionary<string, SortedDictionary<string, int>> userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();
            char[] splitter = { ' ', '=', '\'' };
            while (input[0] != "end")
            {
                int repeatCount = 1;
                if (userLogs.ContainsKey(input[input.Length-1]))
                {
                    if (userLogs[input[input.Length - 1]].ContainsKey(input[1]))
                    {
                        userLogs[input[input.Length - 1]][input[1]] += 1;
                    }
                    else
                    {
                        repeatCount = 1;
                        userLogs[input[input.Length - 1]].Add(input[1], repeatCount);
                    }
                }
                else
                {
                    repeatCount = 1;
                    userLogs.Add(input[input.Length - 1], new SortedDictionary<string, int>());
                    userLogs[input[input.Length - 1]].Add(input[1], repeatCount);
                }



                input = Console.ReadLine()
                .Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            }


            foreach (var kvp in userLogs)
            {
                Console.WriteLine($"{kvp.Key}: ");

                foreach (var pair in userLogs[kvp.Key])
                {
                    var last = userLogs[kvp.Key].Keys.Last();

                    if (pair.Key.Equals(last))
                    {
                        Console.WriteLine($"{pair.Key} => {pair.Value}. ");
                    } else
                    {
                        Console.Write($"{pair.Key} => {pair.Value}, ");
                    }
                }

            }
        }
    }
}
