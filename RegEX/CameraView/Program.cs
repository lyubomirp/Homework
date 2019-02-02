using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string a = Console.ReadLine();


            int skipElements = input[0];
            int addElements = input[1];

            List<string> result = new List<string>();

            string pattern = "\\|<(\\w{" + skipElements + "})(\\w{0," + addElements + "})";

            MatchCollection collection = Regex.Matches(a, pattern);

            foreach (Match item in collection)
            {
                result.Add(item.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
