using System;

namespace Stack
{
    class StartUp
    {
        static Stack<string> stack = new Stack<string>();
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                UseCommands(input);
                input = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        private static void UseCommands(string input)
        {
            string[] splitInput = input.Split(new char[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries);           

            switch (splitInput[0].ToLower())
            {
                case "push":
                    for (int i = 1; i < splitInput.Length; i++)
                    {
                        stack.Push(splitInput[i]);
                    }                    
                    break;
                case "pop":
                    try
                    {
                        stack.Pop();
                    } catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
    }
}