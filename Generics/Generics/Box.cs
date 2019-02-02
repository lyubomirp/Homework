using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    class Box<T>
    {
        int compareCount;
        List<T> items = new List<T>();

        public int Count
        {
            get
            {
                return compareCount;
            }
        }

        public List<T> Items
        {
            get { return items; }
            set { items = value; }
        }

        public void Comparer(T thingToCompare)
        {
            int result;
            foreach (var item in items)
            {
                result = Comparer<T>.Default.Compare(item, thingToCompare);

                if (result > 0)
                {
                    compareCount++;
                }
            }
        }
    }
}
