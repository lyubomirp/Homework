﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ISpy:ISoldier
    {
        int CodeNumber { get; set; }
    }
}
