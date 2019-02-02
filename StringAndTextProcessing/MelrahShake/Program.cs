using System;
using System.Collections.Generic;
using System.Linq;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }





        static void GetUserInput()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            ShakeIt(input, pattern);
        }

        public static void ShakeIt(string input, string pattern)
        {

            while (pattern.Length>0)
            {
                int indexOne = input.IndexOf(pattern);
                int indexTwo = input.LastIndexOf(pattern);

                if (indexOne != indexTwo)
                {
                    input = input.Remove(indexTwo, pattern.Length);

                    input = input.Remove(indexOne, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }

                else
                {
                    break;
                }

            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);

        }
    }
}
