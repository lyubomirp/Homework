using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Car : Vehicle
    {
        const double airConditioner = 0.9;

        public Car(double fuelQuant, double fuelPerKm, double tankCapacity) : base(fuelQuant, fuelPerKm, tankCapacity)
        {
        }

        public override void DriveVehicle(double distance)
        {
            if (FuelQuantity>= distance * (FuelPerKm + airConditioner))
            {
                FuelQuantity -= distance * (FuelPerKm + airConditioner);
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

    }
}
