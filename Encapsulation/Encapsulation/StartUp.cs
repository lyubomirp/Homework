using System;

namespace Encapsulation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {Box.SurfaceArea(box.Length, box.Width, box.Height):F2}");
                Console.WriteLine($"Lateral Surface Area - {Box.LateralSurface(box.Length, box.Width, box.Height):F2}");
                Console.WriteLine($"Volume - {Box.Volume(box.Length, box.Width, box.Height):F2}");
            } catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
