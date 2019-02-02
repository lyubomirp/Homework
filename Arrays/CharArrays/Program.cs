using System;

namespace CharArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputOne = Console.ReadLine()
                .Split();

            string[] inputTwo = Console.ReadLine()
                .Split();

            CharCompare(inputOne, inputTwo);
        }


        static void CharCompare (string[] a, string[] b)
        {
            char[] charStr = new char[a.Length];
            char[] charStrTwo = new char[b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                charStr = a[i]
                    .ToCharArray();
            }

            for (int i = 0; i < b.Length; i++)
            {
                charStrTwo = b[i]
                    .ToCharArray();
            }


            if (charStr.Length > charStrTwo.Length)
            {
                
                foreach(char res in charStrTwo)
                {
                    Console.Write(res);
                }
                Console.WriteLine();
                foreach (char res in charStr)
                {
                    Console.Write(res);
                }

            } else if (charStrTwo.Length > charStr.Length)
            {
                foreach (char res in charStr)
                {
                    Console.Write(res);
                }
                Console.WriteLine();
                foreach (char res in charStrTwo)
                {
                    Console.Write(res);
                }
            } else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (charStr[i] > charStrTwo[i])
                    {
                        foreach (char res in charStrTwo)
                        {
                            Console.Write(res);
                        }
                        Console.WriteLine();
                        foreach (char res in charStr)
                        {
                            Console.Write(res);
                        }
                        break;
                    } else if (charStrTwo[i] > charStr[i])
                    {
                        foreach (char res in charStr)
                        {
                            Console.Write(res);
                        }
                        Console.WriteLine();
                        foreach (char res in charStrTwo)
                        {
                            Console.Write(res);
                        }
                        break;
                    } else
                    {
                        foreach (char res in charStr)
                        {
                            Console.Write(res);
                        }
                        Console.WriteLine();
                        foreach (char res in charStrTwo)
                        {
                            Console.Write(res);
                        }
                        break;
                    }
                }
            }
        }
    }
}
