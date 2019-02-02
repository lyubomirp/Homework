using System;
using System.Linq;

namespace SieveofEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            int[] inputArray = new int [index+1];
            for (int i = 0; i <= index; i++)
            {
                inputArray[i] = i;
            }

            Sieve(inputArray);
        }
        static void Sieve (int[] a)
        {
            bool[] primeCheck = new bool[a.Length];
            Array.Fill(primeCheck, true);
            int n = a.Length;
            int primeNum = 0;

            primeCheck[0] = false; primeCheck[1] = false;

            for (int i = 0; i < n; i++)
            {

                if (primeCheck[i]){
                    for (int j = 2; j <= n; j++)
                    {
                        primeNum = j*a[i];

                        if (a.Contains(primeNum))
                        {
                            primeCheck[Array.IndexOf(a, primeNum)] = false;
                        }
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (primeCheck[i])
                {
                    Console.Write($"{a[i]} ");
                }
            }
        }
    }
}
