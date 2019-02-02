using System;

namespace CompareFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secNum = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            firstNum = Math.Abs(firstNum);
            secNum = Math.Abs(secNum);

            if (firstNum - secNum > eps)
            {
                Console.WriteLine("False");
            }else
            {
                Console.WriteLine("True");
            }
        }
    }
}
