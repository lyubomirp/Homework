using MilitaryElite.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ICommando:ISpecializedSoldier
    {
        List<Mission> Missions { get; set; }
        void CompleteMission(List<Mission> missions, string missionName);
    }
}
