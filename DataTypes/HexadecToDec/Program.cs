using System;

namespace HexadecToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a, 16);

            Console.WriteLine(b);
        }
    }
}
