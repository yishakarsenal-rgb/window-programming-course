using System;

namespace Exercise12Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a positive integer N (N < 20): ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n < 20)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int col = row; col < row + n; col++)
                    {
                        Console.Write("{0,3}", col);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("please enter number between 1 and 19.");
            }

            Console.ReadKey();
        }
    }
}