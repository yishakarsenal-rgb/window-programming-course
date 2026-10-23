using System;

namespace Exercise6Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            Console.WriteLine("--- Original Code Output ---");
            if (num < 10)
                Console.WriteLine("Number is less than 10");
            else
                if (num < 5)
                    Console.WriteLine("Number is less than 5");
                else
                    Console.WriteLine("Number is equal to or greater than 5");

            Console.WriteLine("\n--- Fixed Code (Using Curly Braces {} and Proper Condition Order) ---");
            if (num < 5)
            {
                Console.WriteLine("Number is less than 5");
            }
            else if (num < 10)
            {
                Console.WriteLine("Number is equal to or greater than 5 and less than 10");
            }
            else
            {
                Console.WriteLine("Number is 10 or greater");
            }

            Console.ReadKey();
        }
    }
}