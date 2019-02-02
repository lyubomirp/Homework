using System;
using System.Linq;

namespace PairsByDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int difference = int.Parse(Console.ReadLine());

            DifferenceNums(input, difference);
        }

        static void DifferenceNums (int[]a, int b)
        {
            int diffChecker = 0;
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diffChecker = a[i] + b;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == diffChecker)
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
