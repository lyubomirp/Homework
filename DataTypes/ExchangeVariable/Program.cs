using System;

namespace ExchangeVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("Before:"+Environment.NewLine+$"a = {b}"+Environment.NewLine+$"b = {a}");
            Console.WriteLine("After:" + Environment.NewLine + $"a = {a}" + Environment.NewLine + $"b = {b}");
        }
    }
}
