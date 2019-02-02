using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < count; i++)
            {
                box.Items.Add(double.Parse(Console.ReadLine()));
            }

            double itemToCompareTo = double.Parse(Console.ReadLine());

            box.Comparer(itemToCompareTo);

            Console.WriteLine(box.Count);
        }

    }
}
