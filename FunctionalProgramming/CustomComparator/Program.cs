using System;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> comparator = x =>
            {
                return x.Where(y=>y%2==0).OrderBy(y => y).ToArray();
            };
            Func<int[], int[]> comparatorOdd = x =>
            {
                return x.Where(y => y % 2 != 0).OrderBy(y => y).ToArray();
            };

            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] evens = comparator(input);
            int[] odds = comparatorOdd(input);

            

            Console.Write(string.Join(' ', evens) + " ");
            Console.Write(string.Join(' ', odds));
        }
    }
}
