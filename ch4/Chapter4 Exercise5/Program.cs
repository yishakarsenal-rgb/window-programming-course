using System;

namespace Chapter4_Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;
            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow Error: The product ({0}) is too large to fit in a byte (0-255).", num1 * num2);
                Console.WriteLine("System Message: {0}", ex.Message);
            }
            Console.ReadLine();
        }
    }
}