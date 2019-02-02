using System;
using System.Linq;

namespace EnglishName
{
    class Program
    {
        static void Main(string[] args)
        {
            LastDigit(Console.ReadLine());
        }
























        static void LastDigit (string a)
        {
            var c = a.Reverse().ToArray();
            var b = c.Take(1).ToArray();

            int q = (int)Char.GetNumericValue(b[0]);

            switch (q)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }

        }
    }
}
