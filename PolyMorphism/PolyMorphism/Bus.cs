using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Bus : Vehicle
    {
        private bool isFull;

        public bool IsFull
        {
            get { return isFull; }
            set { isFull = value; }
        }


        public Bus(double fuelQuant, double fuelPerKm, double tankCapacity) : base(fuelQuant, fuelPerKm, tankCapacity)
        {
        }

        public override void DriveVehicle(double distance)
        {
            double airConditioner = 0;
            if (isFull)
            {
                airConditioner = 1.4;
            }
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

    }
}
