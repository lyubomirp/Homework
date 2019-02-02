using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : Vehicle
    {
        const double airConditioner = 1.6;

        public Truck(double fuelQuant, double fuelPerKm, double tankCapacity) : base(fuelQuant, fuelPerKm, tankCapacity)
        {
        }

        public override void DriveVehicle(double distance)
        {
            if (FuelQuantity >= distance * (FuelPerKm + airConditioner))
            {
                FuelQuantity -= distance * (FuelPerKm + airConditioner);
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public override void RefuelVehicle(double litres)
        {
            if (litres <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else if (TankCapacity < FuelQuantity + litres)
            {
                Console.WriteLine($"Cannot fit {litres} fuel in the tank");
            }
            else
            {
                FuelQuantity += litres*0.95;

            }
        }
    }
}
