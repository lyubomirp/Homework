using System;
using System.Linq;

namespace MultiplyLargeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().TrimStart('0');
            string b = Console.ReadLine();

            if (b == "0" || a == "0")
            {
                Console.WriteLine("0");
            } else if (b == "1")
            {
                Console.WriteLine(a);
            } else if (a =="1")
            {
                Console.WriteLine(b);
            } else
            {
                a = StringReverse(a);
                int remainder = 0;
                int prod = 0;
                string result = string.Empty;

                for (int i = 0; i < a.Length; i++)
                {
                    int number = int.Parse(a[i].ToString()) * int.Parse(b);

                    number += remainder;

                    prod = number % 10;

                    remainder = number / 10;

                    result += prod.ToString();
                }
                if (remainder > 0)
                {
                    result += remainder.ToString();
                }
                Console.WriteLine(StringReverse(result));
            }


        }

        static string StringReverse(string a)
        {
            char[] stringToReverse = a.ToCharArray();

            stringToReverse = stringToReverse.Reverse().ToArray();

            return new string(stringToReverse);
        }
    }
}
