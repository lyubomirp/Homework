using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone(Console.ReadLine().Split(' ').ToList(),
                Console.ReadLine().Split(' ').ToList());
            smartphone.Call();
            smartphone.SurfTheWeb();
            
        }
    }
}
