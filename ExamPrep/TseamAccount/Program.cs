using System;
using System.Collections.Generic;
using System.Linq;

namespace TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<string> gamesLib = new List<string>();

            foreach (var item in input)
            {
                if (!gamesLib.Contains(item))
                {
                    gamesLib.Add(item);
                }
            }

            string[] commands = Console.ReadLine()
                .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Play!")
            {
                switch (commands[0])
                {
                    case "Install":
                        if (!gamesLib.Contains(commands[1]))
                        {
                            gamesLib.Add(commands[1]);
                        }
                        break;
                    case "Uninstall":
                        if (gamesLib.Contains(commands[1]))
                        {
                            gamesLib.Remove(commands[1]);
                        }
                        break;
                    case "Update":
                        if (gamesLib.Contains(commands[1]))
                        {
                            gamesLib.Remove(commands[1]);
                            gamesLib.Add(commands[1]);
                        }
                        break;
                    case "Expansion":
                        if (gamesLib.Contains(commands[1]))
                        {
                            int index = 0;
                            index = gamesLib.IndexOf(commands[1])+1;
                            gamesLib.Insert(index, $"{commands[1]}:{commands[2]}");
                        }
                        break;
                }
                commands = Console.ReadLine()
                .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(' ', gamesLib));
        }
    }
}
