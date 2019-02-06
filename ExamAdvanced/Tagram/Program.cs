using System;
using System.Collections.Generic;
using System.Linq;

namespace Tagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userInput = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();


            while (userInput[0] != "end")
            {
                if(userInput[0] == "ban")
                {
                    if (users.ContainsKey(userInput[1]))
                    {
                        users.Remove(userInput[1]);
                    }
                } else
                {
                    string name = userInput[0];
                    string tag = userInput[1];
                    int likes = int.Parse(userInput[2]);

                    if (users.ContainsKey(name))
                    {
                        if (users.ContainsKey(tag))
                        {
                            users[name][tag] += likes;
                        }
                        else
                        {
                            users[name].Add(tag, likes);
                        }
                    }
                    else
                    {
                        users.Add(name, new Dictionary<string, int>());
                        users[name].Add(tag, likes);
                    }
                }

                userInput = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }


            foreach (var person in users.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x=>x.Value.Keys.Count()))
            {
                Console.WriteLine(person.Key);

                foreach (var tag in person.Value)
                {
                    Console.WriteLine($"- {tag.Key}: {tag.Value}");
                }
            }
        }
    }
}
