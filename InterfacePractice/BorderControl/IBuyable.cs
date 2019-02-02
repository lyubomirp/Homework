using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    interface IBuyable
    {
        string Name { get; set; }
        void BuyFood();
        int GetFood { get; }
    }
}
