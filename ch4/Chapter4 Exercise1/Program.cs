using System;

namespace Chapter4_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Inside try block: Executing task...");
            }
            finally
            {
                Console.WriteLine("Inside finally block: Cleanup always executes!");
            }
            Console.ReadKey();
        }
    }
}