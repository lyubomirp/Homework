using System;

namespace NameRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> LengthChecker = (name, number) =>
            {
                if (name.Length <= number)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach(var name in names)
            {
                if (LengthChecker(name, length) == true)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
