using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface IPrivate:ISoldier
    {
        double Salary { get; set; }
    }
}
