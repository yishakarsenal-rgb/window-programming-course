using System;

namespace Chapter4_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                int x = 10 / zero;
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine("Specific Handler Caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Handler Caught: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}