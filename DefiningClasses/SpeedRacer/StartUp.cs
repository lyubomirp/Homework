using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carName = carInfo[0];
                double carFuel = double.Parse(carInfo[1]);
                double carEfficiency = double.Parse(carInfo[2]);

                cars.Add(new Car(carName, carFuel, carEfficiency));
            }

            string[] drive = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (drive[0] != "End")
            {
                string model = drive[1];
                int distance = int.Parse(drive[2]);

                Car currentCar = cars.Find(x => x.GetModel == model);

                if(currentCar.GetFuelAmmount >= distance * currentCar.GetKmPHr)
                {
                    currentCar.Distance += distance;
                    currentCar.GetFuelAmmount -= distance * currentCar.GetKmPHr;
                    
                } else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                drive = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.GetModel} {car.GetFuelAmmount:F2} {car.Distance}");
            }
        }
    }
}
