using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("please enter the value to flip coin");
            int noOfFlips =Convert.ToInt32( Console.ReadLine());
            int head = 0, tail = 0;
            double headPercentage, tailPercentage;
            if (noOfFlips >= 0)
            {
                for(int i = 0; i < noOfFlips; i++)
                {
                    
                    Random random = new Random();
                    int number = random.Next(0, 2);
                    if (number == 0)
                    {
                        head++;
                    }
                    else if (number == 1)
                    {
                        tail++;
                    }
                }
               
            }
            else
            {
                Console.WriteLine("please enter positive number");
            }
     
            headPercentage = (head * 100) / noOfFlips;
            Console.WriteLine("percentage of heads:"+headPercentage);
            tailPercentage = (tail * 100) / noOfFlips;
            Console.WriteLine("percentage of heads:" + tailPercentage);
        }
    }
}
