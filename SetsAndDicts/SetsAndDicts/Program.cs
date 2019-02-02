using System;
using System.Collections.Generic;

namespace SetsAndDicts
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, string> usernames = new Dictionary<string, string>();


            for (int i = 0; i < count; i++)
            {
                string userName = Console.ReadLine();

                if (!usernames.ContainsKey(userName))
                {
                    usernames.Add(userName, string.Empty);
                }
            }

            foreach (var name in usernames)
            {
                Console.WriteLine(name.Key);
            }
        }
    }
}
