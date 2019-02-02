using System;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }




        static void GetUserInput()
        {
            char[] delimiter = { ' ', '\t' };
            string[] input = Console.ReadLine()
                .Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

            GameMath(input);
        } 



        static void GameMath (string[] input)
        {
            decimal result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                decimal number = decimal.Parse(input[i].Substring(1, input[i].Length - 2));
                char firstOperator = input[i][0];
                char secondOperator = input[i][input[i].Length - 1];

                int index = char.ToUpper(firstOperator) - 64;
                int index1 = char.ToUpper(secondOperator) - 64;

                if (char.IsLower(firstOperator))
                {
                    number = number * index;
                } else
                {
                    number = number / index;
                }

                if (char.IsLower(secondOperator))
                {
                    number += index1;
                }
                else
                {
                    number -= index1;
                }

                result += number;
            }

            Console.WriteLine($"{result:F2}");
        }
    }
}
