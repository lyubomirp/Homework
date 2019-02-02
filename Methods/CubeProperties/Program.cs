using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeParam = Console.ReadLine();

            CubeCalculations(cubeSide, cubeParam);
        }

        static void CubeCalculations (double b, string a)
        {
            double result = 0;
            switch (a)
            {
                case "face":
                    result = Math.Sqrt(2 * (Math.Pow(b, 2)));
                    Console.WriteLine($"{result:F2}");
                    break;
                case "space":
                    result = Math.Sqrt(3 * (Math.Pow(b, 2)));
                    Console.WriteLine($"{result:F2}");
                    break;
                case "volume":
                    result = Math.Pow(b, 3);
                    Console.WriteLine($"{result:F2}");
                    break;
                case "area":
                    result = 6 * (Math.Pow(b, 2));
                    Console.WriteLine($"{result:F2}");
                    break;
            }
        }
    }
}
