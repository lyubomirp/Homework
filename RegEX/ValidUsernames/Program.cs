using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\w{2,25})([ ,\/\\\(\)])*(\w{2,25})";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> result = new List<string>();

            char[] numCompare = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach(Match item in matches)
            {
                if (char.IsDigit(item.Groups[1].Value[0]))
                {
                    result.Add(item.Groups[3].Value);
                } else if (char.IsDigit(item.Groups[3].Value[0]))
                {
                    result.Add(item.Groups[1].Value);
                } else
                {
                    result.Add(item.Groups[1].Value);
                    result.Add(item.Groups[3].Value);
                }
            }

            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}
