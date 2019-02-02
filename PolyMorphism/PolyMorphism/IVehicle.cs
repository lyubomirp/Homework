using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    interface IVehicle
    {
        double FuelQuantity { get; set; }
        double FuelPerKm { get; set; }
        double TankCapacity { get; set; }

        void DriveVehicle(double distance);
        void RefuelVehicle(double litres);

    }
}
