using System;
using System.Linq;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input = Console.ReadLine();
            string result = string.Empty;


            char[] denum = { '\\', '|', '<' };

            string[] keyWords = input1.Split(denum, StringSplitOptions.RemoveEmptyEntries);

            while (input.Contains(keyWords[keyWords.Length-1]))
            {
                if (input.IndexOf(keyWords[0]) < input.IndexOf(keyWords[keyWords.Length - 1]))
                {
                    int startIndex = input.IndexOf(keyWords[0]) + keyWords[0].Length;
                    int endIndex = input.IndexOf(keyWords[keyWords.Length - 1]) - startIndex;


                    result += input.Substring(startIndex, endIndex);

                    input = string.Join("", input.Skip(input.IndexOf(keyWords[keyWords.Length - 1]) + keyWords[keyWords.Length - 1].Length));

                    if (!input.Contains(keyWords[keyWords.Length - 1]))
                    {
                        break;
                    }
                } else
                {
                    input = string.Join("", input.Skip(keyWords[keyWords.Length - 1].Length));
                    if (!input.Contains(keyWords[keyWords.Length - 1]))
                    {
                        break;
                    }
                }
            }

            if (result == string.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
