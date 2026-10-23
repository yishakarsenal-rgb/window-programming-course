using System;

namespace Exercise11Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter the number of lines in the multiplication table: ");
            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,4}", i * j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}