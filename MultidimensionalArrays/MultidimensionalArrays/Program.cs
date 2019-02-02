using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] constraints = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[,] palindromes = new string[constraints[0], constraints[1]];

            for (int i = 0; i < constraints[0]; i++)
            {
                char letter = alphabet[i];


                for (int j = 0; j < constraints[1]; j++)
                {
                    palindromes[i, j] = alphabet[i].ToString();
                    palindromes[i, j] += letter.ToString();
                    letter++;
                    palindromes[i, j] += alphabet[i].ToString();
                }
            }

            for (int i = 0; i < palindromes.GetLength(0); i++)
            {
                for (int j = 0; j < palindromes.GetLength(1); j++)
                {
                    Console.Write(palindromes[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
