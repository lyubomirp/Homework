using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTesting
{
    public class Database
    {
        int[] repo;
        Person[] people;

        public Database()
        {
            if(repo == null)
            {
                repo = new int[16];
            }
            if(people == null)
            {
                people = new Person[16];
            }
        }

        public Database(params int[] items)
        {
            if (repo == null)
            {
                repo = new int[16];
            }
            if (items.Length > 16)
            {
                throw new InvalidOperationException();
            }
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public Database(params Person[] people)
        {
            if (people == null)
            {
                people = new Person[16];

            }
            if (people.Length > 16)
            {
                throw new InvalidOperationException();
            }
            foreach (var item in people)
            {
                Add(item);
            }
        }

        public void Add(Person element)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == null)
                {
                    people[i] = element;
                    break;
                }
                if (people[i].Id == element.Id)
                {
                    throw new InvalidOperationException();
                }
                if(people[i].Username == element.Username)
                {
                    throw new InvalidOperationException();
                }
                
            }
        }

        public void Add(int element)
        {
            if (!repo.Contains(0))
            {
                throw new InvalidOperationException();
            }

            for (int i = 0; i < repo.Length; i++)
            {
                if (repo[i] == 0)
                {
                    repo[i] = element;
                    break;
                }
            }
        }


        public int Remove()
        {
            for (int i = people.Length - 1; i >= 0; i--)
            {
                if (people[i] != null)
                {
                    people[i] = null;
                    return 0;
                }
            }
            return -1;
        }

        public Person FindByUsername(string name)
        {
            if(name == string.Empty || name == null)
            {
                throw new ArgumentNullException();
            }
            if(!people.Any(x=>x.Username == name))
            {
                throw new InvalidOperationException();
            }

            return people.First(x => x.Username == name);
        }


        public Person FindById(long id)
        {
            if (id<0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (!people.Any(x => x.Id == id))
            {
                throw new InvalidOperationException();
            }

            return people.First(x => x.Id == id);
        }

        public int RemoveInt()
        {
            for (int i = repo.Length - 1; i >= 0; i--)
            {
                if (repo[i] != 0)
                {
                    repo[i] = 0;
                    return repo[i];
                }
            }
            throw new InvalidOperationException();
        }

        public int[] Fetch()
        {
            List<int> toReturn = new List<int>();

            for (int i = 0; i < repo.Length; i++)
            {
                if (repo[i] == 0)
                {
                    break;
                }
                toReturn.Add(repo[i]);
            }
            return toReturn.ToArray();
        }
    }
}
