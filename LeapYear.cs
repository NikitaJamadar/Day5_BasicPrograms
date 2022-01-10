using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("plase enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("entered year is leap year");
            }
            else
            {
                Console.WriteLine("entered year is not leap year");
            }
        }
    }
}
