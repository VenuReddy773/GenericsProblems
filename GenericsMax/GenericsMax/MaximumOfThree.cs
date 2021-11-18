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
        public static string MaxString(string first, string second, string third)
        {
            if ((first.Length).CompareTo(second.Length) > 0 && (first.Length).CompareTo(third.Length) > 0)
            {
                return first;
            }
            if ((second.Length).CompareTo(third.Length) > 0 && (second.Length).CompareTo(first.Length) > 0)
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
