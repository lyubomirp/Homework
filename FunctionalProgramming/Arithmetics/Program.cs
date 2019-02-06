using System;
using System.Collections.Generic;
using System.Linq;

namespace Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> Add = number => number.Select(x => x + 1).ToList();
            Func<List<int>, List<int>> Subtract = number => number.Select(x => x - 1).ToList();
            Func<List<int>, List<int>> Multiply = number => number.Select(x => x * 2).ToList();
            Action<List<int>> Print = number =>
            {
                foreach (var num in number)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            };

            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = Add(numbers);
                        break;
                    case "subtract":
                        numbers = Subtract(numbers);
                        break;
                    case "multiply":
                        numbers = Multiply(numbers);
                        break;
                    case "print":
                        Print(numbers);
                        break;
                }
                command = Console.ReadLine();

            }
        }
    }
}
