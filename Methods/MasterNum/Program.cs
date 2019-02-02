using System;
using System.Linq;
using System.Collections.Generic;

namespace MasterNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());


            for (int i = 1; i <= range; i++)
            {
                 if (PalindromeCheck(i) && EvenDigitCheck(i) && DivisionCheck(i))
                {
                    Console.WriteLine(i);
                }
            }

        }







        static bool PalindromeCheck (int a)
        {
            int num = a;
            int digitCont = 0;

            while (num > 0)
            {
                int digit = num % 10;
                digitCont = digitCont * 10 + digit;
                num = num / 10;
            }

            if (a == digitCont)
            {
                return true;
            }return false;
        }


        static bool DivisionCheck (int a)
        {
            List<int> digits = new List<int>();

            while (a > 0)
            {
                digits.Add(a % 10);
                a = a / 10;
            }

            int wholeSum = digits.Sum();

            if (wholeSum % 7 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool EvenDigitCheck (int a)
        {
            string evenDigits = a.ToString();

            if(evenDigits.Contains('2') || evenDigits.Contains('4') || evenDigits.Contains('6') || evenDigits.Contains('8') || evenDigits.Contains('0'))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
