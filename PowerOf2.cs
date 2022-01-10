using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOf2
    {
        public static void FindPower()
        {
            Console.WriteLine("enter power");
            int n = Convert.ToInt32(Console.ReadLine());
            int power;
            for(int i = 1; i <= n; i++)
            {
                power = 2 * i;
                Console.WriteLine(power);
            }
        }
    }
}
