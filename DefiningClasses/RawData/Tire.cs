using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Tire
    {
        int Age { get; set; }
        double Pressure { get; set; }

        public double GetPressure
        {
            get
            {
                return Pressure;
            }
        }

        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
    }
}
