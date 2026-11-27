using System;

namespace Chapter4_Extra5
{
    class Program
    {
        static void TriggerDivision()
        {
            int a = 50;
            int b = 0;
            int result = a / b;
        }
        static void Main(string[] args)
        {
            try
            {
                TriggerDivision();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Message:    " + ex.Message);
                Console.WriteLine("Source:     " + ex.Source);
                Console.WriteLine("TargetSite: " + ex.TargetSite);
                Console.WriteLine("StackTrace:\n" + ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}