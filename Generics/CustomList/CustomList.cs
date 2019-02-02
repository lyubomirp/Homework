using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomList
{
    class CustomList<T>
    {
        List<T> container = new List<T>();

        public void Add(T element)
        {
            container.Add(element);
        }

        public T Remove(int index)
        {
            T item = container[index];
            container.RemoveAt(index);
            return item;
        }

        public void Sort()
        {
            for (int i = 0; i < container.Count()-1; i++)
            {
                T minElement = container[i];
                int index = 0;
                for (int j = 1; j < container.Count(); j++)
                {
                    int result = Comparer<T>.Default.Compare(minElement, container[j]);
                    if (result > 0)
                    {
                        minElement = container[j];
                        index = j;
                    }
                }
                int res = Comparer<T>.Default.Compare(minElement, container[i]);
                if (res!=0)
                {
                    Swap(i, index);
                }
            }
        }

        public void Print()
        {
            foreach (var item in container)
            {
                Console.WriteLine(item);
            }
        }

        public bool Contains(T element)
        {
            if (container.Contains(element))
            {
                return true;
            }

            return false;
        }

        public void Swap(int index1, int index2)
        {
            T itemOne = container[index1];
            T itemTwo = container[index2];

            container[index1] = itemTwo;
            container[index2] = itemOne;
        }

        public int CountGreaterThan(T element)
        {
            int result;
            int count = 0;

            foreach (var item in container)
            {
                result = Comparer<T>.Default.Compare(item, element);

                if (result > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            T largestItem = container[0];
            int result;
            foreach (var item in container)
            {
                result = Comparer<T>.Default.Compare(item, largestItem);

                if (result > 0)
                {
                    largestItem = item;
                }
            }

            return largestItem;

        }

        public T Min()
        {
            T smallestItem = container[0];
            int result;
            foreach (var item in container)
            {
                result = Comparer<T>.Default.Compare(item, smallestItem);

                if (result < 0)
                {
                    smallestItem = item;
                }
            }

            return smallestItem;
        }

    }
}
