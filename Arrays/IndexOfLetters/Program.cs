using System;
using System.Linq;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            CharacterIndex(input);
        }

        static void CharacterIndex(char[] a)
        {
            char[] alphabet = new char[26];
            int[] indexes = new int[a.Length];
            int i = 0;
            char letters = 'a';

            while (i < alphabet.Length)
            {
                alphabet[i] = letters;

                letters++;
                i++;
            }


            for (int j = 0; j < a.Length; j++)
            {
                indexes[j] = (Array.IndexOf(alphabet, a[j]));



                Console.WriteLine($"{a[j]} -> {indexes[j]}");
            }
        }
    }
}
