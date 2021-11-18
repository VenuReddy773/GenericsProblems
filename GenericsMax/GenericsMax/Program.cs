using System;

namespace GenericsMax
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome To Program To Find Max Of Three\n");
                Console.WriteLine("choose Option:\n 1.IntMax\n 2.FloatMax\n 3.StringMax\n 4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Three Numbers to Check Max.");
                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        int third = Convert.ToInt32(Console.ReadLine());
                        int result = MaximumOfThree.MaxInt(first, second, third);
                        Console.WriteLine(result + " is Maximum Of Three\n");
                        break;
                    case 2:
                        Console.WriteLine("Enter Three Float Numbers to Check Max.");
                        double first1 = Convert.ToDouble(Console.ReadLine());
                        double second1 = Convert.ToDouble(Console.ReadLine());
                        double third1 = Convert.ToDouble(Console.ReadLine());
                        double result1 = MaximumOfThree.MaxFloat(first1, second1, third1);
                        Console.WriteLine(result1 + " is Maximum Of Three\n");
                        break;
                    case 3:
                        Console.WriteLine("Enter Three Strings to Check Max.");
                        string firstString = Convert.ToString(Console.ReadLine());
                        string secondString = Convert.ToString(Console.ReadLine());
                        string thirdString = Convert.ToString(Console.ReadLine());
                        string result2 = MaximumOfThree.MaxString(firstString, secondString, thirdString);
                        Console.WriteLine(result2 + " is Maximum Of Three\n");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}