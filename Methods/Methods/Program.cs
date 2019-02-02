using System;

namespace Methods
{
    class Program
    {
        public static void Greeting (string a, string b)
        {
            string c =  a + b;
            Console.WriteLine(c);
        } 
        static void Main(string[] args)
        {
            Greeting("Hello, ", Console.ReadLine() + "!");
        }
    }
}
