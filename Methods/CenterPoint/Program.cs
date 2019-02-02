using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstPoint = double.Parse(Console.ReadLine());
            double secondPoint = double.Parse(Console.ReadLine());
            double thirdPoint = double.Parse(Console.ReadLine());
            double fourthPoint = double.Parse(Console.ReadLine());


            ClosestToCenter(firstPoint, secondPoint, thirdPoint, fourthPoint);
        }



        static void ClosestToCenter(double a, double b, double c, double d)
        {
            double diameterOne = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));
            double diameterTwo = Math.Sqrt(Math.Pow(d, 2) + Math.Pow(c, 2));

            if (diameterOne < diameterTwo)
            {
                Console.WriteLine("({0}, {1})", a, b);
            }
            else
            {
                Console.WriteLine("({0}, {1})", c, d);
            }
        }
    }
}

