using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    class Smartphone : IBrowseable, ICallable
    {
        List<string> numbers;
        List<string> websites;

        public Smartphone(List<string> numbers, List<string> websites)
        {
            this.Numbers = numbers;
            this.Websites = websites;
        }

        public List<string> Websites { get => websites; set => websites = value; }
        public List<string> Numbers { get => numbers; set => numbers = value; }

        public void Call()
        {
            foreach (var num in numbers)
            {
                if (num.Any(x => char.IsLetter(x)))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }
                Console.WriteLine($"Calling... {num}");
            }
        }

        public void SurfTheWeb()
        {
            foreach (var site in websites)
            {
                if (site.Any(x => char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                Console.WriteLine($"Browsing: {site}!");
            }
        }
    }
}
