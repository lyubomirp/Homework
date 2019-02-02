using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class PersonByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if(result == 0)
            {
                char firstPersonChar = Char.ToLower(x.Name[0]);
                char secondPersonChar = Char.ToLower(y.Name[0]);

                result = firstPersonChar.CompareTo(secondPersonChar);
            }

            return result;
        }
    }
}
