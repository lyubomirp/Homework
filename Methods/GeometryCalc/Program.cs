using System;

namespace GeometryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            AreaCalculation(figureType);
        }

        static void AreaCalculation (string a)
        {
            switch (a)
            {
                case "triangle":

                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());

                    double result = (height * side) / 2;

                    Console.WriteLine($"{result:F2}");

                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRec = double.Parse(Console.ReadLine());

                    double resultRec = heightRec * width;

                    Console.WriteLine($"{resultRec:F2}");

                    break;
                case "square":
                    double sideSq = double.Parse(Console.ReadLine());

                    double resultSq = Math.Pow(sideSq, 2);

                    Console.WriteLine($"{resultSq:F2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());

                    double resultCirc = Math.PI * Math.Pow(radius, 2);

                    Console.WriteLine($"{resultCirc:F2}");
                    break;
            }
        }
    }
}
