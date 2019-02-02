using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class Person
    {
        long id;
        string username;

        public Person(long id, string username)
        {
            this.Id = id;
            this.Username = username;
        }

        public long Id
        {
            get
            {
                return id;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            private set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
            }
        }

        public override string ToString()
        {
            return $"ID: {id}{Environment.NewLine}Username: {username}";
        }
    }
}
