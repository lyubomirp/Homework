using System;
using System.Collections.Generic;
using System.Linq;

namespace Rectangles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] ammountAndPoints = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < ammountAndPoints[0]; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Rectangle rectangle = new Rectangle(input[0], double.Parse(input[1]), double.Parse(input[2]), new double[] { double.Parse(input[3]), double.Parse(input[4]) });
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < ammountAndPoints[1]; i++)
            {
                string[] ids = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                bool result = Rectangle.Intersect(rectangles.Find(x => x.Id == ids[0]), rectangles.Find(x => x.Id == ids[1]));


                if (result)
                {
                    Console.WriteLine("true");
                } else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
