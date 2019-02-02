using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Engine
    {
        private string model;
        private double power;
        private double displacement;
        private string efficiency;

        public string Model
        {
            get
            {
                return model;
            }
        }
        public double Power
        {
            get
            {
                return power;
            }
        }

        public double Displacement
        {
            get
            {
                return displacement;
            }
        }

        public string Efficiency
        {
            get
            {
                return efficiency;
            }
        }


        public Engine(string model, double power, double displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public Engine(string model, double power) : this (model, power, 0, "n/a")
        {

        }
        public Engine(string model, double power, double displacement) : this (model, power, displacement, "n/a")
        {

        }
        public Engine(string model, double power, string efficiency) : this (model, power, 0, efficiency)
        {

        }
    }
}
