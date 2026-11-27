using System;

namespace Chapter4_Extra2
{
    class Program
    {
        static void Main(string[] args)
        {
            object boxedValue = "Unity University";
            try
            {
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