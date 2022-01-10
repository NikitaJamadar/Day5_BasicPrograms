using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {          
           
            Console.WriteLine("1.Flip coin 2.Leap year 3.Power of 2 4.hormonic number 5.factors 6.quotient reminder 7.swap numbers 8.Even Odd 9.Vowel consonant 10.Largest number ");
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    FlipCoin.FlipTheCoin();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerOf2.FindPower();
                    break;
                case 4:
                    HormonicNumber.PrintHormonicSeries();
                    break;
                case 5:
                    PrimeFactors.FindPrimeFactors();
                    break;
                case 6:
                    QuotientAndReminder.ComputeQuotientAndReminder();
                    break;
                case 7:
                    SwapNumbers.SwapTheNumbers();
                    break;
                case 8:
                    EvenOddNumber.CheckEvenOddNumber();
                    break;
                case 9:
                    VowelConsonant.ChcekVowelOrConsonant();
                    break;
                case 10:
                    LargestNumber.LargestAmongThree();
                    break;
                default:
                    Console.WriteLine("you enter wrong choice");
                    break;
            }
        }
    }
}
