using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] elementsInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < elementsInput.Length; j++)
                {
                    elements.Add(elementsInput[j]);
                }
            }

            Console.WriteLine(string.Join(' ', elements));
        }
    }
}
