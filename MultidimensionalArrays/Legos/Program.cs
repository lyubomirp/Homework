using System;
using System.Collections.Generic;
using System.Linq;

namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            int legoCount = int.Parse(Console.ReadLine());
            int[][] combined = new int[legoCount*2][];

            for (int i = 0; i < legoCount*2; i++)
            {
                combined[i] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
            }

            List<int> sums = new List<int>();

            for (int row = 0; row < combined.Length/2; row++)
            {
                sums.Add(combined[row].Length + combined[row + (combined.Length / 2)].Length);
            }


            if (sums.Distinct().Count() == 1)
            {

                for (int i = (combined.Length/2); i < combined.Length; i++)
                {
                    combined[i] = combined[i].Reverse().ToArray();
                }

                List<List<int>> finalArray = new List<List<int>>();

                for (int i = 0; i < combined.Length/2; i++)
                {
                    finalArray.Add(new List<int>());
                }

                for (int row = 0; row < combined.Length/2; row++)
                {
                    finalArray[row] = combined[row].ToList().Concat(combined[row + (combined.Length / 2)]).ToList();
                }

                foreach (var list in finalArray)
                {
                    Console.WriteLine("[" + string.Join(", ", list) + "]");
                }

            } else
            {
                Console.WriteLine($"The total number of cells is: {sums.Sum()}");
            }
        }
    }
}
