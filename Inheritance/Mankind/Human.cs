using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    class Human
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                switch (CheckInput(value))
                {
                    case 1:
                        throw new ArgumentException("Expected upper case letter! Argument: firstName");
                    case 2:
                        throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                    default:
                        break;
                }
                firstName = value;
            }
        }

        private int CheckInput(string value)
        {
            if (!char.IsUpper(value[0]))
            {
                return 1;
            }
            if (value.Length <= 3)
            {
                return 2;
            }
            return 0;
        }

        private string secondName;

        public string SecondName
        {
            get { return secondName; }
            set
            {
                switch (CheckSecondName(value))
                {
                    case 1:
                        throw new ArgumentException("Expected upper case letter! Argument: lastName");
                    case 2:
                        throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                    default:
                        break;
                }
                secondName = value;
            }
        }

        private int CheckSecondName(string value)
        {
            if (!char.IsUpper(value[0]))
            {
                return 1;
            }
            if (value.Length <= 2)
            {
                return 2;
            }
            return 0;
        }

        public Human(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

    }
}
