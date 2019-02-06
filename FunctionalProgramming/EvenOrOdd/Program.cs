using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> Evens = x => x % 2 == 0; 
            Predicate<int> Odds = x => x % 2 != 0;

            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int borderFirst = input[0];
            int borderSecond = input[1];

            List<int> numbers = new List<int>();


            for (int i = borderFirst; i <= borderSecond; i++)
            {
                numbers.Add(i);
            }

            string type = Console.ReadLine();

            switch (type)
            {
                case "even":
                    foreach(var num in numbers)
                    {
                        if (Evens(num) == true)
                        {
                            Console.Write(num + " ");
                        }
                    }
                    break;
                case "odd":
                    foreach (var num in numbers)
                    {
                        if (Odds(num) == true)
                        {
                            Console.Write(num + " ");
                        }
                    }
                    break;
            }
        }
    }
}
