using System;
using System.Collections.Generic;
using System.Linq;

namespace IvanchoParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<string>, string, string, List<string>> Remove = (x, y, z) =>
            {
                switch (y)
                {
                    case "StartsWith":
                        x.RemoveAll(u => u.ToLower().StartsWith(z.ToLower()));
                        break;
                    case "Length":
                        x.RemoveAll(u => u.Length == int.Parse(z));
                        break;
                    case "EndsWith":
                        x.RemoveAll(u => u.ToLower().EndsWith(z.ToLower()));
                        break;
                    default:
                        break;
                }
                return x;
            };

            Func<List<string>, string, string, List<string>> Double = (x, y, z) =>
            {
                switch (y)
                {
                    case "StartsWith":
                        List<string> toDoubleStarts = x.Where(u => u.ToLower().StartsWith(z.ToLower())).ToList();
                        for (int i = 0; i < toDoubleStarts.Count; i++)
                        {
                            x.Add(toDoubleStarts[i]);
                        }
                        break;
                    case "Length":
                        List<string> toDoubleLength = x.Where(u => u.Length == int.Parse(z)).ToList();
                        for (int i = 0; i < toDoubleLength.Count; i++)
                        {
                            x.Add(toDoubleLength[i]);
                        }
                        break;
                    case "EndsWith":
                        List<string> toDoubleEnds = x.Where(u => u.ToLower().EndsWith(z.ToLower())).ToList();
                        for (int i = 0; i < toDoubleEnds.Count; i++)
                        {
                            x.Add(toDoubleEnds[i]);
                        }
                        break;
                    default:
                        break;
                }
                return x;
            };

            List<string> guests = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Party!")
            {
                if (commands.Length < 3)
                {
                    commands = Console.ReadLine()
                        .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                if (commands[0] == "Remove")
                {
                    Remove(guests, commands[1], commands[2]);
                }
                if (commands[0] == "Double")
                {
                    Double(guests, commands[1], commands[2]);
                }

                commands = Console.ReadLine()
                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            }

            if (guests.Any())
            {
                Console.WriteLine(String.Join(", ", guests) + " are going to the party!");

            } else
            {
                Console.WriteLine("Nobody is going to the party!");

            }
        }
    }
}
