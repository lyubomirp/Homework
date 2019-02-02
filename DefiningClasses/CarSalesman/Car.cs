using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        private string model;
        private Engine engine;
        private double weight;
        private string color;

        public Car(string model, Engine engine, double weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public Car(string model, Engine engine) : this(model, engine, 0, "n/a")
        {
        }

        public Car(string model, Engine engine, double weight) : this(model, engine, weight, "n/a")
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, 0, color)
        {
        }


        public string Model
        {
            get
            {
                return model;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
        }
        public Engine CarEngine
        {
            get
            {
                return engine;
            }
        }
    }
}
