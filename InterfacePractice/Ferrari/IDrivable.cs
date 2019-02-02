using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface IDrivable
    {
        string Driver { get; set; }
        string Model { get; }

        string PushBrakes();
        string PushGas();

    }
}
