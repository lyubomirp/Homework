using System;
using System.Collections.Generic;
using System.Text;
using TeamBuilder.Exceptions;

namespace TeamBuilder
{
    class Player
    {
        Checker checker = new Checker();

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                checker.NameCheck(value);
                name = value;
            }
        }

        private int endurance;

        private int Endurance
        {
            get { return endurance; }
            set
            {
                if (checker.StatCheck(value))
                {
                    WrongValue("endurance");
                }
                endurance = value;
            }
        }

        private void WrongValue(string v)
        {
            switch (v)
            {
                case "endurance":
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                case "sprint":
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                case "dribble":
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                case "passing":
                    throw new ArgumentException("Passing should be between 0 and 100.");
                case "shooting":
                    throw new ArgumentException("Shooting should be between 0 and 100.");
            }
        }

        private int sprint;

        private int Sprint
        {
            get { return sprint; }
            set
            {
                if (checker.StatCheck(value))
                {
                    WrongValue("sprint");
                }
                sprint = value;
            }
        }

        private int dribble;

        private int Dribble
        {
            get { return dribble; }
            set
            {
                if (checker.StatCheck(value))
                {
                    WrongValue("dribble");
                }
                dribble = value;
            }
        }

        private int passing;

        private int Passing
        {
            get { return passing; }
            set
            {
                if (checker.StatCheck(value))
                {
                    WrongValue("passing");
                }
                passing = value;
            }
        }

        private int shooting;

        private int Shooting
        {
            get { return shooting; }
            set
            {
                if (checker.StatCheck(value))
                {
                    WrongValue("shooting");
                }
                shooting = value;
            }
        }

        private int average;

        public int Average
        {
            get { return average; }
            private set { average = value; }
        }

        public Player(string name, int end, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = end;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            Average = CalculateAverage(end, sprint, dribble, passing, shooting);
        }

        private int CalculateAverage(int end, int sprint, int dribble, int passing, int shooting)
        {
            double total = end + sprint + dribble + passing + shooting;
            double avg = total / 5;
            return (int)Math.Round(avg);
        }
    }
}
