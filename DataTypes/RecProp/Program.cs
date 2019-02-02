using System;
using System.Numerics;

namespace RecProp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var area = a * b;
            var perim = (2 * a) + (2 * b);
            var diag = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine(perim);
            Console.WriteLine(area);
            Console.WriteLine(diag);
        }
    }
}
