using MilitaryElite.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface IEngineer:ISpecializedSoldier
    {
        List<Repairs> Repairs { get; set; }

    }
}
