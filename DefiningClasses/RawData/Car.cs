using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Car
    {
        string Model { get; set; }

        public List<Tire> Tires { get; } = new List<Tire>();

        public Engine GetEngine { get; } = new Engine();

        public Cargo GetCargo { get; } = new Cargo();

        public string GetModel
        {
            get
            {
                return Model;
            }
        }

        public Car (string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.GetEngine = engine;
            this.GetCargo = cargo;
            this.Tires = tires;
        }
    }
}
