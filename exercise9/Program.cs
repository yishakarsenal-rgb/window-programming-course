using System;

namespace Exercise9Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop 1
            Console.WriteLine("loop 1");
            for (int i = 10; i < 5; i = i + 1)
            {
                Console.WriteLine("How many times do I print?");
            }

            // loop 2
            Console.WriteLine("loop 2");
            for (int i = 10; i >= 1; i = i - 1)
            {
                Console.WriteLine("How many times do I print? ", i);
            }

            // loop 3
            Console.WriteLine(" loop 3 ");
            int j = 1;
            while (j < 20) 
            {
                Console.WriteLine("How many times do I print? ", j);
                j++;
            }

            Console.ReadKey();
        }
    }
}