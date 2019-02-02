using MordorCruelPlan.Moods;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorCruelPlan
{
    abstract class Mood
    {
        public abstract string resMood { get; }

        public static Mood GetMood(int value)
        {
            if (value < -5)
            {
                return new Angry();
            }
            if (value >= -5 && value <= 0)
            {
                return new Sad();
            }
            if (value >= 1 && value <= 15)
            {
                return new Happy();
            }
            return new JavaScript();
        }
    }
}
