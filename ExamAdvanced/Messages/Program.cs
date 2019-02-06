using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string pattern = @"((s\:)([^;]*)\;r\:)([^;]*)\;m\-\-(\W(([A-Za-z]+)*|(\s+)*)+\W)$";
            string input = Console.ReadLine();
            List<string> res = new List<string>();
            int megabytes = 0;

            while (count > 0)
            {
                count--;
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string currName = match.Groups[3].Value;
                    string currTo = match.Groups[4].Value;

                    string msg = match.Groups[5].Value;

                    string name = string.Empty;
                    string to = string.Empty;

                    Untangler(currName, ref name, ref megabytes);
                    Untangler(currTo, ref to, ref megabytes);


                    res.Add($"{name} says {msg} to {to}");
                }
                input = Console.ReadLine();
            }

            foreach (var message in res)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine($"Total data transferred: {megabytes}MB");
        }

        private static void Untangler(string currName, ref string name, ref int megabytes)
        {
            for (int i = 0; i < currName.Length; i++)
            {
                if (char.IsLetter(currName[i]) || char.IsSeparator(currName[i]))
                {
                    name += currName[i];
                }
                if (char.IsDigit(currName[i]))
                {
                    megabytes += int.Parse(currName[i].ToString());
                }
            }
        }
    }
}
