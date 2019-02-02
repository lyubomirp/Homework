using System;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            for (int checkNum = 0; checkNum <= startNum; checkNum++)
            {
                bool primeCheck = true;
                for (int squareCheck = 2; squareCheck <= Math.Sqrt(checkNum); squareCheck++)
                {
                    if (checkNum % squareCheck == 0)
                    {
                        primeCheck = false;
                        break;
                    }
                }
                if (checkNum>=2){
                    Console.WriteLine($"{checkNum} -> {primeCheck}");
                } else
                {
                    Console.WriteLine("");
                }
            }

        }
    }
}
