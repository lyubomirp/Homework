using System;

namespace partOfASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstBorder = int.Parse(Console.ReadLine());
            int secBorder = int.Parse(Console.ReadLine());

            char charConv;
            string result = string.Empty;


            for (int i = firstBorder; i <= secBorder; i++)
            {

                charConv = (char)i;

                result += charConv + " ";
            }

            Console.WriteLine(result);
        }
    }
}
