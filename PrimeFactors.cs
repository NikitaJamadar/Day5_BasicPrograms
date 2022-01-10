using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PrimeFactors
    {
        public static void FindPrimeFactors()
        {
            Console.WriteLine("enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            Console.Write("prime factors are:");
            for(int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i+" ");
                }
               
            }
        }
    }
}
