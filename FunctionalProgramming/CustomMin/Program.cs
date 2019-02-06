using System;
using System.Linq;

namespace CustomMin
{
    class Program
    {
        static Func<int[], int> MinimalNumber = numbers => numbers.Min();

        static void Main(string[] args)
        {
            Console.WriteLine(MinimalNumber(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray()));
        }
    }
}
