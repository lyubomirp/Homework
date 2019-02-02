using System;

namespace CustomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            CustomList<string> customList = new CustomList<string>();

            while (input[0] != "END")
            {
                DeployCommands(input, customList);
                input = Console.ReadLine()
                .Split();
            }
        }

        private static void DeployCommands(string[] input, CustomList<string> list)
        {
            switch (input[0].ToLower())
            {
                case "max":
                    Console.WriteLine(list.Max());
                    break;
                case "min":
                    Console.WriteLine(list.Min());
                    break;
                case "print":
                    list.Print();
                    break;
                case "add":
                    list.Add(input[1]);
                    break;
                case "remove":
                    list.Remove(int.Parse(input[1]));
                    break;
                case "contains":
                    Console.WriteLine(list.Contains(input[1])); 
                    break;
                case "swap":
                    list.Swap(int.Parse(input[1]), int.Parse(input[2]));
                    break;
                case "greater":
                    Console.WriteLine(list.CountGreaterThan(input[1]));
                    break;
                case "sort":
                    list.Sort();
                    break;
            }
        }
    }
}
