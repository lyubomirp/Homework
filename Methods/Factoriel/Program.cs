using System;
using System.Numerics;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int factNum = int.Parse(Console.ReadLine());

            Factoriel(factNum);
        }

        static void Factoriel (int a)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}
