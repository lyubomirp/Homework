using System;

namespace MaxMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());


            GetMax(firstNum, secondNum, thirdNum);
        }














        static void GetMax(int a, int b, int c)
        {

            if (a > c && a > b)
            {
                Console.WriteLine(a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
