using System;

namespace FibonacciNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibNumInput = int.Parse(Console.ReadLine());

            FibonacciNumbers(fibNumInput);
        }






        static void FibonacciNumbers(int end)
        {
            int firstNum = 0;
            int secNum = 1;
            int sum = 0;

            for (int i = 0; i <= end; i++)
            {
                sum = firstNum + secNum;
                secNum = firstNum;
                firstNum = sum;
            }

            Console.WriteLine(sum);

        }
    }
}
