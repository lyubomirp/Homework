using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCruelPlan.Foods
{
    class Mushrooms:Food
    {
        public override int happinessLevel
        {
            get
            {
                return -10;
            }
        }
    }
}
