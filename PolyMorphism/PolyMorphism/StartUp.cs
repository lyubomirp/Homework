using System;

namespace Vehicles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] carArgs = Console.ReadLine().Split();
            string[] truckArgs = Console.ReadLine().Split();
            string[] busArgs = Console.ReadLine().Split();

            Car car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]), double.Parse(carArgs[3]));
            Truck truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]), double.Parse(truckArgs[3]));
            Bus bus = new Bus(double.Parse(busArgs[1]), double.Parse(busArgs[2]), double.Parse(busArgs[3]));

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string thingToDo = input[0];
                string vehicleType = input[1];
                double distanceOrFuelQuant = double.Parse(input[2]);

                if(thingToDo == "Drive")
                {
                    switch (vehicleType)
                    {
                        case "Car":
                            car.DriveVehicle(distanceOrFuelQuant);
                            break;
                        case "Truck":
                            truck.DriveVehicle(distanceOrFuelQuant);
                            break;
                        case "Bus":
                            bus.IsFull = true;
                            bus.DriveVehicle(distanceOrFuelQuant);
                            break;
                    }
                }

                if(thingToDo == "DriveEmpty")
                {
                    bus.IsFull = false;
                    bus.DriveVehicle(distanceOrFuelQuant);
                }

                if (thingToDo == "Refuel")
                {
                    switch (vehicleType)
                    {
                        case "Car":
                            car.RefuelVehicle(distanceOrFuelQuant);
                            break;
                        case "Truck":
                            truck.RefuelVehicle(distanceOrFuelQuant);
                            break;
                        case "Bus":
                            bus.RefuelVehicle(distanceOrFuelQuant);
                            break;
                    }
                }
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
