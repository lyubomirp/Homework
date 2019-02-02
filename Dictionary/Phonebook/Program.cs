using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> book = new Dictionary<string, string>();

            string[] input = Console.ReadLine()
                .Split();

            PhonebookSearch(book, input);
        }

        static void PhonebookSearch (Dictionary<string, string> a, string[] b)
        {
            while (!b.Equals("END"))
            {
                if (b[0].Equals("A"))
                {
                    if (a.ContainsKey(b[1]))
                    {
                        a[b[1]] = b[2];
                    }
                    else
                    {
                        a.Add(b[1], b[2]);
                    }
                }
                else if (b[0].Equals("S"))
                {
                    if (!a.ContainsKey(b[1]))
                    {
                        Console.WriteLine($"Contact {b[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{b[1]} -> {a[b[1]]}");
                    }
                }
                else if (b[0].Equals("ListAll"))
                {
                    var keySort = a.Keys.ToList();
                    keySort.Sort();
                    foreach (var key in keySort)
                    {
                        Console.WriteLine($"{key} -> {a[key]}");
                    }
                }
                b = Console.ReadLine()
                    .Split();

                if (b[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
