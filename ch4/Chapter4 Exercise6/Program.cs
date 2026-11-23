using System;

namespace Chapter4_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter miles driven: ");
                double miles = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter gallons used: ");
                double gallons = Convert.ToDouble(Console.ReadLine());

                if (gallons == 0)
                {
                    throw new DivideByZeroException("Gallons used cannot be zero.");
                }

                double mpg = miles / gallons;
                Console.WriteLine("Miles Per Gallon (MPG): {0:F2}", mpg);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input: Please enter valid numeric values for miles and gallons.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Math Error: {0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}