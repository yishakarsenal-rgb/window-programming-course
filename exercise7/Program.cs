using System;

namespace Exercise7Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Add all numbers from x to y
            Console.WriteLine("--- Part 1: Sum of numbers from x to y ---");
            Console.Write("Enter starting number (x): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ending number (y): ");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers from {0} to {1} is: {2}", x, y, sum);

            // Part 2: Right-aligned perpendicular isosceles triangle of stars
            Console.WriteLine("\n--- Part 2: Right-Aligned Triangle of Stars ---");
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces
                for (int s = 1; s <= rows - i; s++)
                {
                    Console.Write("  ");
                }
                // Print stars
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