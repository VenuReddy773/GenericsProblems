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
                Console.WriteLine("choose Option:\n 1.IntMax\n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter Three Numbers to Check Max.");
                        int first = Convert.ToInt32(Console.ReadLine());
                        int second = Convert.ToInt32(Console.ReadLine());
                        int third = Convert.ToInt32(Console.ReadLine());
                        int result = MaximumOfThree . MaxInt(first, second, third);
                        Console.WriteLine(result +" is Maximum Of Three");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
                
            
           
        }
    }
}

        
