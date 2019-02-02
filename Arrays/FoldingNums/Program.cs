using System;
using System.Linq;

namespace FoldingNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            FoldSum(input);
        }

        static void FoldSum (int[] input)
        {
            int n = input.Length;
            int step = 1;
            int[] firstRow = new int [n/2];
            int[] secRow = new int[n/2];
            int[] sum = new int [n/2];


            for (int j = (firstRow.Length) / 2; j < firstRow.Length; j++)
            {
                for (int i = 0; i < n/4; i++)
                {

                    firstRow[i] = input[((n-1)/4)-i];

                }
                firstRow[j] = input[n - step];
                step++;
            }

            for (int i = 0; i < secRow.Length; i++)
            {
                secRow[i] = input[(n / 4) + i];
            }

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRow[i] + secRow[i];

                Console.Write($"{sum[i]} ");
            }
            Console.WriteLine();
        }
    }
}
