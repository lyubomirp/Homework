using System;

namespace BooleanVar
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            bool b= Convert.ToBoolean(a);

            if (b)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }
        }
    }
}
