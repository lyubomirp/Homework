using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace FromNBaseToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = GetUserInput();
            ConvertToBaseTen(input);
        }

        public static BigInteger[] GetUserInput()
        {
            string[] input = Console.ReadLine()
                .Split();

            BigInteger[] values = new BigInteger[2];

            values[0] = BigInteger.Parse(input[0]);
            values[1] = BigInteger.Parse(input[1]);

            return values;
        }

        public static void ConvertToBaseTen(BigInteger[] a)
        {
            BigInteger numberBase = a[0];
            BigInteger number = a[1];
            List<BigInteger> result = new List<BigInteger>();
            BigInteger res = 0;
            int i = 0;

            while (number > 0)
            {
                BigInteger remainder = number % 10;
                number = number / 10;
                result.Add(remainder * BigInteger.Pow(numberBase, i));
                i++;
            }

            foreach(var num in result)
            {
                res += num;
            }

            Console.WriteLine(res);
        }
    }
}
