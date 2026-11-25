using System;

namespace Chapter4_Extra2_InvalidCast
{
    class Program
    {
        static void Main(string[] args)
        {
            object boxedValue = "Unity University";

            try
            {
                // Attempting to unbox a string as a double triggers InvalidCastException
                double gpa = (double)boxedValue;
                Console.WriteLine("GPA: " + gpa);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("InvalidCastException Caught: Incompatible type conversion.");
                Console.WriteLine("Message: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}