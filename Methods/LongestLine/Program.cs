using System;

namespace LongestLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstPoint = double.Parse(Console.ReadLine());
            double secPoint = double.Parse(Console.ReadLine());
            double thirdPoint = double.Parse(Console.ReadLine());
            double fourthPoint = double.Parse(Console.ReadLine());
            double fifthPoint = double.Parse(Console.ReadLine());
            double sixthPoint = double.Parse(Console.ReadLine());
            double seventhPoint = double.Parse(Console.ReadLine());
            double eightPoint = double.Parse(Console.ReadLine());

            if (Math.Abs(firstPoint-secPoint) >= Math.Abs(fifthPoint-sixthPoint) && Math.Abs(thirdPoint-fourthPoint) >= Math.Abs(seventhPoint - eightPoint))
            {
                ClosestToCenter(firstPoint, secPoint, thirdPoint, fourthPoint);
            } else
            {
                ClosestToCenter(fifthPoint, sixthPoint, seventhPoint, eightPoint);
            }

        }



        static void ClosestToCenter(double a, double b, double c, double d)
        {
            double diameterOne = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double diameterTwo = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(d, 2));

            if (diameterOne <= diameterTwo)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", a, b, c, d);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", c, d, a, b);
            }
        }
    }
}
