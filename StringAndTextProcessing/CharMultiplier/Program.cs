using System;
using System.Linq;

namespace CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine()
                .Split();

            int result = 0;


            char[] first = n[0].ToCharArray();
            char[] second = n[1].ToCharArray();

            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                result += (int)first[i] * (int)second[i];
            }

            if (first.Length > second.Length)
            {
                var length = first.Length - second.Length;
                var rest = first.Skip(second.Length).ToArray();
                for (int i = 0; i < length; i++)
                {
                    result += (int)rest[i];
                }
            } else if (second.Length > first.Length)
            {
                var length = second.Length - first.Length;
                var rest = second.Skip(first.Length).ToArray();
                for (int i = 0; i < length; i++)
                {
                    result += (int)rest[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
