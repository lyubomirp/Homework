using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>()
            {
                {"Pesho", "Kurva"},
                {"Evlogi", "Pedal" }
            };

            phonebook.Add("Geizer", "Meizer");

            Console.WriteLine(phonebook["Pesho"]);
            Console.WriteLine(phonebook["Geizer"]);
        }
    }
}
