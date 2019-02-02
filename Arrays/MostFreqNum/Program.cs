using System;
using System.Linq;

namespace MostFreqNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            FrequentNumbers(input);
                
        }


        static void FrequentNumbers (int[] a)
        {
            int[] result = new int[a.Length];
            int count = 0;
            int index = 0;
            int mostFreq = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                result[i] = count;
                count = 0;
            }

            index = result.Max();

            Console.WriteLine(a[Array.IndexOf(result, index)]);
        }
    }
}
