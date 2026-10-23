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
            Console.WriteLine("\nloop 2 Fixed (changed i=i+1 to i=i-1 so it counts down 10 to 1):");
            for (int i = 10; i >= 1; i = i - 1)
            {
                Console.WriteLine("How many times do I print? (i = {0})", i);
            }

            // loop 3: Originally infinite because i was not incremented inside while loop. Fixed by adding i++:
            Console.WriteLine("\nloop 3 Fixed (added i++ inside the while loop):");
            int j = 1;
            while (j < 5) // Reduced to 5 for clean display
            {
                Console.WriteLine("How many times do I print? (j = {0})", j);
                j++;
            }

            Console.ReadKey();
        }
    }
}