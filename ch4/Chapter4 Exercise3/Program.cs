using System;

namespace Chapter4_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correct Order (Model A): Specific exception first, general Exception last
            try
            {
                int zero = 0;
                int x = 10 / zero;
            }
            catch (DivideByZeroException ex) // Specific handler runs first
            {
                Console.WriteLine("Specific Handler Caught: " + ex.Message);
            }
            catch (Exception ex) // General fallback handler runs last
            {
                Console.WriteLine("General Handler Caught: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}