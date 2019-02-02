using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int intCount = int.Parse(Console.ReadLine());

            List<int> repeats = new List<int>();

            for (int i = 0; i < intCount; i++)
            {
                repeats.Add(int.Parse(Console.ReadLine()));
            }

            repeats = repeats.GroupBy(x => x)
                .Where(g => g.Count() % 2 == 0)
                .First()
                .ToList();

            if (repeats.Count > 0)
            {
                Console.WriteLine(string.Join(' ', repeats.Distinct()));
            }
        }
    }
}
