using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], List<int>, List<int>> divisible = (x, y) =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    y = y.Where(z => z % x[i] == 0).ToList();
                }

                return y;
            };

            int border = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            int[] divisors = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            FillErUp(numbers, border);

            Console.WriteLine(string.Join(' ', divisible(divisors, numbers)));

        }

        private static void FillErUp(List<int> numbers, int border)
        {
            for (int i = 1; i <= border; i++)
            {
                numbers.Add(i);
            }
        }
    }
}
