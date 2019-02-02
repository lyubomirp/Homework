using System;
using System.Text.RegularExpressions;

namespace ContainsWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $@"\b[^?.!]*\b{input}\b[^?.!]*";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
