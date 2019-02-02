using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    class Car : IDrivable
    {
        string driver;
        string model;

        public string Driver { get => driver; set => driver = value; }
        public string Model { get => "488-Spider"; }

        public Car(string driver)
        {
            this.Driver = driver;
        }

        public string PushBrakes()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Zadu6avam sA!";
        }
    }
}
