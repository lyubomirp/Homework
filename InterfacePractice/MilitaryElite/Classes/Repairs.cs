using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class Repairs
    {
        private string partName;

        public string PartName
        {
            get { return partName; }
            set { partName = value; }
        }

        private int hoursWorked;

        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public override string ToString()
        {
            return $"Part Name: {partName} Hours Worked: {hoursWorked}{Environment.NewLine}";
        }
    }
}
