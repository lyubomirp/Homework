using System;
using System.Collections.Generic;

namespace PrimeCheckRange
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secNum = long.Parse(Console.ReadLine());
            bool isPrime;
            List<long> primes = new List<long>();


            for (long i = firstNum; i <= secNum; i++)
            {
                isPrime = PrimeCheck(i);

                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            Console.WriteLine(string.Join(", ", primes));
        }




        static bool PrimeCheck(long n)
        {
            if (n < 2)
            {
                return false;
            }

            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
