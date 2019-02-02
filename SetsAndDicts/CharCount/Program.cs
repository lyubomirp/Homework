using System;
using System.Collections.Generic;

namespace CharCount
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            SortedDictionary<char, int> occurenceCount = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (occurenceCount.ContainsKey(input[i]))
                {
                    occurenceCount[input[i]]++;
                } else
                {
                    occurenceCount.Add(input[i], 1);
                }
            }


            foreach (var letter in occurenceCount)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
