using System;
using System.Linq;

namespace AddLargeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().TrimStart('0');
            string input2 = Console.ReadLine().TrimStart('0');

            input = StringReverse(input);
            input2 = StringReverse(input2);

            bool isAboveTen = false;


            string result = string.Empty;

            if (input.Length > input2.Length)
            {
                int padLength = input.Length - input2.Length;
                input2 = input2.PadRight(padLength+input2.Length, '0');
            }
            if (input2.Length > input.Length) 
            {
                int padLength = input2.Length - input.Length;
                input = input.PadRight(padLength+input.Length, '0');
            }

            for (int i = 0; i < Math.Min(input.Length, input2.Length); i++)
            {


                int firstNumber = int.Parse(input[i].ToString());
                int secNumber = int.Parse(input2[i].ToString());


                int sum = firstNumber + secNumber;
                sum += (isAboveTen ? 1 : 0);
                isAboveTen = false;

                if (sum > 9)
                {
                    isAboveTen = true;
                    sum -= 10;
                }

                result += sum.ToString();
            }

            if (isAboveTen)
            {
                result += "1";
            }

            Console.WriteLine(StringReverse(result));

        }
        static string StringReverse(string a)
        {
            char[] stringToReverse = a.ToCharArray();

            stringToReverse = stringToReverse.Reverse().ToArray();

            return new string(stringToReverse);
        }
    }
}
