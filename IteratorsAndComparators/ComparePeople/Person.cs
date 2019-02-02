﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComparePeople
{
    class Person:IComparable<Person>
    {
        string name;
        int age;
        string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            int result = this.name.CompareTo(other.name);

            if (result == 0)
            {
                result = this.age.CompareTo(other.age);
            }

            if(result == 0)
            {
                result = this.town.CompareTo(other.town);
            }

            return result;
        }
    }
}