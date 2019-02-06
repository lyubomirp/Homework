using System;

namespace FunctionalProgramming
{
    class Program
    {
        static Action<string[]> PrintNames = name =>
        {
            foreach (var item in name)
            {
                Console.WriteLine("Sir " + item);
            }
        };

        static void Main(string[] args)
        {
            PrintNames(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
