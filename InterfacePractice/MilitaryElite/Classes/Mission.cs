using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class Mission
    {
        private string codeName;

        public string CodeName
        {
            get { return codeName; }
            set { codeName = value; }
        }

        private bool state;

        public bool State
        {
            get { return state; }
            set { state = value; }
        }

        public override string ToString()
        {
            if(state)
            {
                return $"Code Name: {codeName} State: Finished";
            }

            return $"Code Name: {codeName} State: inProgress";
        }
    }
}
