using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    class StartUp
    {
        static List<string> content = new List<string>();
        static ListyIterator listyIterator = new ListyIterator(content);
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> content = new List<string>();

            while (input != "END")
            {
                UseCommands(input);
                input = Console.ReadLine();
            }
        }

        private static void UseCommands(string input)
        {
            string[] splitInput = input.Split();

            switch (splitInput[0].ToLower())
            {
                case "create":
                    for (int i = 1; i < splitInput.Length; i++)
                    {
                        content.Add(splitInput[i]);
                    }
                    listyIterator = new ListyIterator(content);
                    break;
                case "move":
                    Console.WriteLine(listyIterator.MoveNext());
                    break;
                case "print":
                    listyIterator.Print();
                    break;
                case "hasnext":
                    Console.WriteLine(listyIterator.HasNext()); 
                    break;
                case "printall":
                    listyIterator.PrintAll();
                    break;
            }
        }
    }
}
