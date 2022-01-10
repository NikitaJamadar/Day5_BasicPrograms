using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class UserInput
    {
        public static void PrintName()
        {
            Console.WriteLine("please enter the name");
            string name = Console.ReadLine();
        int length = name.Length;
            if (length >= 3)
            {
                Console.WriteLine("hello " + name + " how are you?");
                Console.WriteLine("hello {0} how are you?", name);
            }
            else
            {
                Console.WriteLine("please enter min 3 characters");
            }
        }
    }
}
