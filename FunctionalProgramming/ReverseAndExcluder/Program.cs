using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExcluder
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int, List<int>> NumRemover = (x, y) =>
             {
                 return x.Where(z => z % y != 0).Reverse().ToList();
             };

            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int excluder = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(' ', NumRemover(input, excluder)));
        }
    }
}
