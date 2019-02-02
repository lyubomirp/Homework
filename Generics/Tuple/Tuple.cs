using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    class Tuple<T,V,U>
    {
        T firstItem;
        V secondItem;
        U thirdItem;

        public T FirstItem
        {
            get { return firstItem; }
            set { firstItem = value; }
        }
        public V SecondItem
        {
            get { return secondItem; }
            set { secondItem = value; }
        }
        public U ThirdItem
        {
            get { return thirdItem; }
            set { thirdItem = value; }
        }

        public override string ToString()
        {
            return $"{firstItem} -> {secondItem} -> {thirdItem}";
        }
    }
}
