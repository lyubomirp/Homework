using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Cargo
    {
        int CargoWeight { get; set; }
        string CargoType { get; set; }

        public string GetCargoType
        {
            get
            {
                return CargoType;
            }
        }

        public Cargo() : this(0, "") { }


        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoType = cargoType;
            this.CargoWeight = cargoWeight;
        }
    }
}
