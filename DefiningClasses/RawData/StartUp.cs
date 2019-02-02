using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] currentCar = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(currentCar[1]), int.Parse(currentCar[2]));
                Cargo cargo = new Cargo(int.Parse(currentCar[3]), currentCar[4]);
                Tire tire1 = new Tire(int.Parse(currentCar[6]), double.Parse(currentCar[5]));
                Tire tire2 = new Tire(int.Parse(currentCar[8]), double.Parse(currentCar[7]));
                Tire tire3 = new Tire(int.Parse(currentCar[10]), double.Parse(currentCar[9]));
                Tire tire4 = new Tire(int.Parse(currentCar[12]), double.Parse(currentCar[11]));

                List<Tire> tires = new List<Tire> { tire1, tire2, tire3, tire4 };

                cars.Add(new Car(currentCar[0], engine, cargo, tires));
            }

            string cargoType = Console.ReadLine();

            switch (cargoType)
            {
                case "fragile":
                    foreach (var car in cars.Where(x => x.GetCargo.GetCargoType == cargoType && x.Tires.Any(y => y.GetPressure < 1)))
                    {
                        Console.WriteLine(car.GetModel);
                    }
                    break;
                case "flamable":
                    foreach (var car in cars.Where(x => x.GetCargo.GetCargoType == cargoType && x.GetEngine.GetEnginePower> 250))
                    {
                        Console.WriteLine(car.GetModel);
                    }
                    break;
            }
        }
    }
}
