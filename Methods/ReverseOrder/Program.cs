using System;
using System.Linq;

namespace ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseOrder(Console.ReadLine());
        }

        static void ReverseOrder (string a)
        {
            var b = a.Reverse().ToArray();

            Console.WriteLine(b);
        }
    }
}
