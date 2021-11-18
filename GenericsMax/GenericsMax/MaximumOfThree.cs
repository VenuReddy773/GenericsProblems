using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsMax
{
    class MaximumOfThree
    {
        public static int MaxInt(int first,int second,int third)
        {
            if(first.CompareTo(second) > 0 && first.CompareTo(third) >0)
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
        public static double MaxFloat(double first, double second, double third)
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
