using System;
using System.Linq;

namespace DecToHexAndBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = a;
            string resultHex = string.Empty;
            int remainder = 0;
            string resultBin = string.Empty;

            while (a > 0)
            {
                remainder = a % 16;
                if (remainder > 9)
                {
                    switch (remainder)
                    {
                        case 10:
                            resultHex += "A";
                            break;
                        case 11:
                            resultHex += "B";
                            break;
                        case 12:
                            resultHex += "C";
                            break;
                        case 13:
                            resultHex += "D";
                            break;
                        case 14:
                            resultHex += "E";
                            break;
                        case 15:
                            resultHex += "F";
                            break;
                    }
                }
                else
                {
                    remainder.ToString();
                    resultHex += remainder;
                }
                a = a / 16;
            }
            Console.WriteLine(resultHex.Reverse().ToArray());

            while (b > 0)
            {
                remainder = b % 2;
                remainder.ToString();
                resultBin += remainder;
                b = b / 2;
            }
            Console.WriteLine(resultBin.Reverse().ToArray());
        }
    }
}
