using System;

namespace Exercise14Application
{
    class Program
    {
        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("2016 = {0}", IfYearIsLeap(2016));
            Console.WriteLine("2018 = {0}", IfYearIsLeap(2018));

            Console.ReadKey();
        }
    }
}   