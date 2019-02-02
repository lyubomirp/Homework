using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    class ListyIterator : IEnumerator<string>
    {
        List<string> container = new List<string>();
        int counter = 0;

        public string Current => container[counter];

        object IEnumerator.Current => container[counter];

        public ListyIterator(List<string> container)
        {
            this.container = container;
        }

        public bool MoveNext()
        {
            try
            {
                var checker = container[counter + 1];
                counter++;
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        public bool HasNext()
        {
            try
            {
                var checker = container[counter + 1];
                return true;
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }      

        public void Print()
        {
            Console.WriteLine(container[counter]);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", container));

        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
