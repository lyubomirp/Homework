using System;
using System.Linq;
using System.Numerics;

namespace SeqOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Sequencer(input);
        }


        static void Sequencer(int[] a)
        {
            int bestLength = 0;
            int[] result = new int[a.Length];
            int number = 0;
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] == a[i+1])
                {
                    bestLength++;
                } else
                {
                    result[i] += bestLength;
                    bestLength = 0;
                }
            }

            result[result.Length - 1] = bestLength;

            number = result.Max();

            for (int i = 0; i <= number; i++)
            {
                int index = ((Array.IndexOf(result, number)-number)+i);

                Console.Write($"{a[index]} ");
            }
            
        }
    }
}