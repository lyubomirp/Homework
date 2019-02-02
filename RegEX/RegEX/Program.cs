using System;
using System.Text.RegularExpressions;

namespace RegEX
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern = @"(^|(?<=\s))[a-zA-Z]+([-.]\w*|(\d+)|)@(\w+)[-.](\w+)([-.]((\w+)[-.]*(\w+)))?";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
