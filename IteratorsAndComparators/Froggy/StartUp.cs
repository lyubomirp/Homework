using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            Lake<int> lake = new Lake<int>(input);

                Console.WriteLine(string.Join(", ", lake));
        }
    }
}
