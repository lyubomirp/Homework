using System;
using System.Collections.Generic;
using System.Linq;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputOne = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double[] inputTwo = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Center firstCenter = new Center();
            firstCenter.X = inputOne[0];
            firstCenter.Y = inputOne[1];

            Center secCenter = new Center();
            secCenter.X = inputTwo[0];
            secCenter.Y = inputTwo[1];

            Circle firstCircle = new Circle();
            firstCircle.Radius = inputOne[2];

            Circle secCircle = new Circle();
            secCircle.Radius = inputTwo[2];


            bool inters = Center.Intersect(firstCenter.X, firstCenter.Y, secCenter.X, secCenter.Y, firstCircle.Radius, secCircle.Radius);

            if (inters)
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }
        }

    }

    class Center
    {
        public double X { get; set; }
        public double Y { get; set; }
    

        public static bool Intersect(double x, double y, double x1, double y1 , double rad1, double rad2)
        {
            double pointDistance = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));

            if (pointDistance <= rad1 + rad2)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }


    class Circle
    {
        public double Radius { get; set; }
    }
}
