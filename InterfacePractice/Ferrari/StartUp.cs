using System;
using System.Linq;

namespace Ferrari
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Car car = new Car(Console.ReadLine());

            Console.WriteLine($"{car.Model}/{car.PushBrakes()}/{car.PushGas()}/{car.Driver}");
        }
    }
}
