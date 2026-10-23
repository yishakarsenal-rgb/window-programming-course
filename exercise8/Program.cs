using System;

namespace Exercise8Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Sum of integers between 1 and 10
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of numbers from 1 to 10");
            Console.WriteLine(sum);

            // Part 2
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}