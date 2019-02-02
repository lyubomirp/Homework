using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacer
{
    class Car
    {
        string Model { get; set; }
        double FuelAmmount { get; set; }
        double KmPHr { get; set; }
        int TravelledDistance { get; set; }

        public Car(string model, double fuelAmmount, double kmphr) 
        {
            this.Model = model;
            this.FuelAmmount = fuelAmmount;
            this.KmPHr = kmphr;
            this.TravelledDistance = 0;
        }

        public string GetModel
        {
            get
            {
                return Model;
            }
        }

        public double GetFuelAmmount
        {
            get
            {
                return FuelAmmount;
            }
            set
            {
                FuelAmmount = value;
            }
        }

        public double GetKmPHr
        {
            get
            {
                return KmPHr;
            }
        }

        public int Distance
        {
            get
            {
                return TravelledDistance;
            }
            set
            {
                TravelledDistance = value;
            }
        }
    }
}
