using System;
using System.Collections.Generic;
using System.Text;

namespace TeamBuilder.Exceptions
{
    public class NameException:Exception
    {
        public override string Message => "A name should not be empty.";
    }
}
