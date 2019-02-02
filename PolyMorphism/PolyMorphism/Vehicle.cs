using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle:IVehicle
    {
        double fuelQuant;
        double fuelPerKm;
        double tankCapacity;

        public double FuelQuantity { get => fuelQuant; set => fuelQuant = value; }
        public double FuelPerKm { get => fuelPerKm; set => fuelPerKm = value; }
        public double TankCapacity { get => tankCapacity; set => tankCapacity=value; }

        public Vehicle(double fuelQuant, double fuelPerKm, double tankCapacity)
        {
            this.fuelQuant = fuelQuant;
            this.fuelPerKm = fuelPerKm;
            this.tankCapacity = tankCapacity;
            if(fuelQuant > tankCapacity)
            {
                this.fuelQuant = 0;
            }
        }

        public virtual void DriveVehicle(double distance)
        {
            
        }

        public virtual void RefuelVehicle(double litres)
        {

            if (litres <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else if (tankCapacity < fuelQuant + litres)
            {
                Console.WriteLine($"Cannot fit {litres} fuel in the tank");
            }
            else
            {
                fuelQuant += litres;

            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {fuelQuant:F2}";
        }
    }
}
