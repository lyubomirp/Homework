using System;
using System.Linq;

namespace UnicodeChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Select(c => (int)c)
                .Select(c => $@"\u{c:x4}");

            Console.WriteLine(string.Concat(input));
        }
    }
}
