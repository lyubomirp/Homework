using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Exceptions
{
    public class InvalidInput:Exception
    {
        public override string Message => "Invalid input!";
    }
}
