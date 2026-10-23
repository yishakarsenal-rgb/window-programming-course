using System;

namespace Exercise13Application
{
    class Program
    {
        static int DivisibleBy2Or3(int a, int b)
        {
            if ((a % 2 == 0 || a % 3 == 0) && (b % 2 == 0 || b % 3 == 0))
            {
                return a * b;
            }
            else
            {
                return a + b;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleBy2Or3(15, 30));
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine(DivisibleBy2Or3(7, 12));

            Console.ReadKey();
        }
    }
}