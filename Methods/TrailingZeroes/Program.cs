using System;
using System.Numerics;

namespace TrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factSum = Factoriel(n);
            int zeroCount = 0;

            while (factSum%10==0)
            {
                zeroCount++;
                factSum = factSum / 10;
            }
            Console.WriteLine(zeroCount);

        }


        static BigInteger Factoriel(int a)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
