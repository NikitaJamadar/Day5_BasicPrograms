using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class HormonicNumber
    {
        public static void PrintHormonicSeries()
        {
            Console.WriteLine("enter the number ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for(int i = 1; i <= n; i++)
                {
                    Console.Write("1/{0}+",i);
                }
            }
        }
    }
}
