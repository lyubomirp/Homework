using System;
using System.Numerics;

namespace CenturiesToNanosec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int boi = a * 100;
            double b = boi * 365.2422;
            int asd = (int)b;
            ulong c = (ulong)b * 24;
            ulong d = c * 60;
            ulong e = d * 60;
            ulong f = e * 1000;
            BigInteger g = f * 1000;
            BigInteger q = g * 1000;


            Console.WriteLine($"{a} centuries = {boi} years = {asd} days = {c} hours = {d} minutes = {e} seconds = {f} milliseconds = {g} microseconds = {q} nanoseconds");
        }
    }
}
