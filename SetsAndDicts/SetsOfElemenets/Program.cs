using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElemenets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int firstSetSize = setSize[0];
            int secondSetSize = setSize[1];

            HashSet<int> firstSet = new HashSet<int>(firstSetSize);
            HashSet<int> secondSet = new HashSet<int>(secondSetSize);
            List<int> repeats = new List<int>(firstSetSize + secondSetSize);

            for (int i = 0; i < firstSetSize; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < secondSetSize; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            repeats = firstSet.Intersect(secondSet).ToList();

            Console.WriteLine(string.Join(' ', repeats));
        }
    }
}
