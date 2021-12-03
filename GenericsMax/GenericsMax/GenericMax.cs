using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMax
{
    class GenericMax<T> where T : IComparable
    {
        public static T MaxGeneric(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}
