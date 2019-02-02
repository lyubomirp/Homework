using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamBuilder.Exceptions
{
    public class Checker
    {
        public void NameCheck(string name)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new NameException();
            }
        }

        public bool StatCheck(int stat)
        {
            if(stat < 0 || stat > 100)
            {
                return true;
            }
            return false;
        }
        
    }
}
