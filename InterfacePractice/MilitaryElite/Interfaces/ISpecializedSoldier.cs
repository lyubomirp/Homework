using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ISpecializedSoldier:IPrivate
    {
        string Corps { get; set; }
    }
}
