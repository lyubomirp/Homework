using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (engineInfo.Length)
                {
                    case 2:
                        Engine engine = new Engine(engineInfo[0], double.Parse(engineInfo[1]));
                        engines.Add(engine);
                        break;
                    case 3:
                        try
                        {
                            Engine engine2 = new Engine(engineInfo[0], double.Parse(engineInfo[1]), double.Parse(engineInfo[2]));
                            engines.Add(engine2);
                        }
                        catch (FormatException)
                        {
                            Engine engine2 = new Engine(engineInfo[0], double.Parse(engineInfo[1]), engineInfo[2]);
                            engines.Add(engine2);
                        }
                        break;
                    case 4:
                        Engine engine3 = new Engine(engineInfo[0], double.Parse(engineInfo[1]), double.Parse(engineInfo[2]), engineInfo[3]);
                        engines.Add(engine3);
                        break;
                }
                
            }
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (carInfo.Length)
                {
                    case 2:
                        Car car = new Car(carInfo[0], engines.Find(x=>x.Model == carInfo[1]));
                        cars.Add(car);
                        break;
                    case 3:
                        try
                        {
                            Car car2 = new Car(carInfo[0], engines.Find(x => x.Model == carInfo[1]), double.Parse(carInfo[2]));
                            cars.Add(car2);
                        }
                        catch (FormatException)
                        {
                            Car car2 = new Car(carInfo[0], engines.Find(x => x.Model == carInfo[1]), carInfo[2]);
                            cars.Add(car2);
                        }
                        break;
                    case 4:
                        Car car3 = new Car(carInfo[0], engines.Find(x => x.Model == carInfo[1]), double.Parse(carInfo[2]), carInfo[3]);
                        cars.Add(car3);
                        break;
                }
            }

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.CarEngine.Model}:");
                Console.WriteLine($"    Power: {car.CarEngine.Power}");
                if (car.CarEngine.Displacement == 0)
                {
                    Console.WriteLine("    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.CarEngine.Displacement}");
                }
                Console.WriteLine($"    Efficiency: {car.CarEngine.Efficiency}");

                if(car.Weight== 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                } else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }

                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
