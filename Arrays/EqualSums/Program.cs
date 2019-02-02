using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            SumsChecker(input);
        }


        static void SumsChecker(int[] a)
        {
            int sumLeft = 0;
            int sumRight = 0;

            string result = string.Empty;


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sumLeft += a[j];
                }

                for (int k = i+1; k < a.Length; k++)
                {
                    sumRight += a[k];
                }

                if (sumLeft == sumRight)
                {
                    result += i;
                }
                sumRight = 0;
                sumLeft = 0;
            }

            if (result == string.Empty)
            {
                Console.WriteLine("no");
            } else
            {
                Console.WriteLine(result);
            }
        }
    }
}
