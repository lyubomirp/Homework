using System;
using System.Collections.Generic;
using System.Linq;

namespace VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> vloggers = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> following = new Dictionary<string, List<string>>();

            while (!(input[0] == "Statistics"))
            {
                if (input[1] == "joined")
                {
                    if (!vloggers.ContainsKey(input[0]))
                    {
                        vloggers.Add(input[0], new List<string>());
                    }
                    if (!following.ContainsKey(input[0]))
                    {
                        following.Add(input[0], new List<string>());
                    }

                }
                else if (input[1] == "followed")
                {
                    if (following.ContainsKey(input[0]) && vloggers.ContainsKey(input[2]))
                    {
                        if (!following[input[0]].Contains(input[2]) && input[0] != input[2])
                        {
                            following[input[0]].Add(input[2]);
                            vloggers[input[2]].Add(input[0]);
                        }
                    }
                }

                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            int i = 1;

            Console.WriteLine($"The V-Logger has a total of {vloggers.Keys.Count} vloggers in its logs.");

            foreach (var vlogger in vloggers.OrderByDescending(x=>x.Value.Count).ThenBy(x=>following[x.Key].Count))
            {
                Console.WriteLine($"{i}. {vlogger.Key} : {vlogger.Value.Count} followers, {following[vlogger.Key].Count} following");

                if (i == 1)
                {
                    foreach(var follower in vlogger.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                i++;
            }
        }
    }
}
