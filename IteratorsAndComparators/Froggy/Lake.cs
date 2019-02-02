using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    class Lake<T> : IEnumerable<T>
    {
        List<T> stones = new List<T>();

        public Lake(List<T> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stones[i];
                }
            }

            for (int j = stones.Count-1; j >=0 ; j--)
            {
                if (j % 2 != 0)
                {
                    yield return stones[j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
