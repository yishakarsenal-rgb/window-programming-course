using System;

namespace Chapter4_Extra3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[2];
            object[] genericArray = courses;
            try
            {
                genericArray[0] = "Windows Programming";
                genericArray[1] = 4021;
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("ArrayTypeMismatchException Caught: Element type does not match array type.");
                Console.WriteLine("Message: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}