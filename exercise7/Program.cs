using System;

namespace Exercise7Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // part1 sum of numbers from x to y
            Console.Write("enter starting number (x): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter ending number (y): ");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers from {0} to {1} is: {2}", x, y, sum);

            // part2
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int s = 1; s <= rows - i; s++)
                {
                    Console.Write("  ");
                }
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