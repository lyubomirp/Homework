using MordorCruelPlan.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCruelPlan
{
    abstract class Food
    {
        public abstract int happinessLevel { get; }

        public static Food GetFood(string id)
        {
            switch (id.ToLower())
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new Others();
            }
        }
    }
}
