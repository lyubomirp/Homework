using System;
using System.Collections.Generic;

namespace SortEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string email = string.Empty;

            EmailSorter(name, email);
        }

        static void EmailSorter(string a, string b)
        {
            Dictionary<string, string> emailBook = new Dictionary<string, string>();

            while (a != "stop")
            {
                b = Console.ReadLine();
                var c = b.ToLower();

                if (c.Contains(".uk") || c.Contains(".us")) { } else { emailBook.Add(a, b); }

                a = Console.ReadLine();


                if (a == "stop")
                {

                    foreach (var kvp in emailBook)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }
            }
        }
    }
}

