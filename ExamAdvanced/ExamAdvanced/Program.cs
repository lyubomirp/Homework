using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottlesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>();
            Stack<int> bottles = new Stack<int>();
            List<int> waste = new List<int>();

            FillCups(cupsInput, cups);
            FillBottles(bottlesInput, bottles);

            while(cups.Any() && bottles.Any())
            {
                waste.Add(Pour(cups, bottles));
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
                Console.WriteLine($"Wasted litters of water: {waste.Sum()}");
            }
            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
                Console.WriteLine($"Wasted litters of water: {waste.Sum()}");
            }
        }

        private static int Pour(Queue<int> cups, Stack<int> bottles)
        {
            int currentCup = cups.Peek();
            int currentBottle = bottles.Pop();
            int remainder = 0;

            if (currentBottle >= currentCup)
            {
                cups.Dequeue();
                remainder = currentBottle - currentCup;

            } else
            {
                currentCup = currentCup - currentBottle;

                RestackCups(cups, currentCup);
            }

            return remainder;
        }

        private static void RestackCups(Queue<int> cups, int currentCup)
        {
            List<int> placeholder = new List<int>();

            foreach (var cup in cups)
            {
                placeholder.Add(cup);
            }

            placeholder[0] = currentCup;
            cups.Clear();

            for (int i = 0; i < placeholder.Count; i++)
            {
                cups.Enqueue(placeholder[i]);
            }
        }

        private static void FillBottles(int[] bottlesInput, Stack<int> bottles)
        {
            for (int i = 0; i < bottlesInput.Length; i++)
            {
                bottles.Push(bottlesInput[i]);
            }
        }

        private static void FillCups(int[] cupsInput, Queue<int> cups)
        {
            for (int i = 0; i < cupsInput.Length; i++)
            {
                cups.Enqueue(cupsInput[i]);
            }
        }
    }
}
