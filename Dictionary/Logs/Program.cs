using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs
{
    class Program
    {
        public static object DIctionary { get; private set; }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            LogsDict(input);
        }


        static void LogsDict(int border)
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();
            int count = 0;
            int sum = 0;
            List<string> ips = new List<string>();

            while (count < border)
            {
                string[] userIn = Console.ReadLine()
                    .Split();
                string name = userIn[1];
                string ip = userIn[0];
                int time = int.Parse(userIn[2]);

                if (result.ContainsKey(name))
                {
                    if (result[name].ContainsKey(ip))
                    {
                        result[name][ip] += time;
                    } else
                    {
                        result[name].Add(ip, time);
                    }
                } else
                {
                    result.Add(name, new Dictionary<string, int>());
                    result[name].Add(ip, time);
                }
                count++;
            }

            foreach (var name in result.OrderBy(x=>x.Key))
            {
                foreach (var ip in result[name.Key].OrderBy(x=> x.Key))
                {
                    sum += ip.Value;
                    ips.Add(ip.Key);
                }

                Console.WriteLine($"{name.Key}: {sum} [{string.Join(", ", ips)}]");
                sum = 0;
                ips.Clear();
            }
        }
    }
}
