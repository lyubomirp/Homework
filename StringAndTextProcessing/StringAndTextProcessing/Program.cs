using System;
using System.Linq;
using System.Numerics;

namespace StringAndTextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = GetUserInput();
            ConvertToNBase(input);
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


        public static void ConvertToNBase(BigInteger[] a)
        {
            BigInteger number = a[1];
            BigInteger numberBase = a[0];
            string result = string.Empty;

            while (number > 0)
            {
                result += number % numberBase;
                number = number / numberBase;
            }

            Console.WriteLine(result.Reverse().ToArray());
        }
    }
}
