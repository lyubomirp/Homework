using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Exceptions
{
    public class InputChecker
    {
        public void CheckInput(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidInput();
            }
        }
    }
}
