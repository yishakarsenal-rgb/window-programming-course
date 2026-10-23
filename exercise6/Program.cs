using System;

namespace Exercise6Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            Console.WriteLine(" not fixed code :-");
            if (num < 10)
                Console.WriteLine("number is less than 10");
            else
                if (num < 5)
                    Console.WriteLine("number is less than 5");
                else
                    Console.WriteLine("number is equal to or greater than 5");

            Console.WriteLine("\n fixed code i use {} and proper condition order):- ");
            if (num < 5)
            {
                Console.WriteLine("number is less than 5");
            }
            else if (num < 10)
            {
                Console.WriteLine("number is equal to or greater than 5 and less than 10");
            }
            else
            {
                Console.WriteLine("number is 10 or greater");
            }

            Console.ReadKey();
        }
    }
}