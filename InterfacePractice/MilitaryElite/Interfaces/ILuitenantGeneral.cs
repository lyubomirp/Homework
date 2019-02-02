using MilitaryElite.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ILuitenantGeneral:IPrivate
    {
        List<Private> Privates { get; set; }
    }
}
