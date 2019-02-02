using System;

namespace VowelOrDigi
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if (a == '0' || a == '1' || a == '2' || a == '3' || a == '4' || a == '5' || a == '5' || a == '6' || a == '7' || a == '8' || a == '9')
            {
                Console.WriteLine("digit");
            } else if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u'){
                Console.WriteLine("vowel");
            } else
            {
                Console.WriteLine("other");
            }
        }
    }
}
