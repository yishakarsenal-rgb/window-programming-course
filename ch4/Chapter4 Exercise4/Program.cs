using System;

namespace Chapter4_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[5];
            list[0] = "Sunday";
            list[1] = "Monday";
            list[2] = "Tuesday";
            list[3] = "Wednesday";
            list[4] = "Thursday";

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("\nException Caught: Array index is out of range!");
                Console.WriteLine("Details: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Array traversal finished.");
            }
            Console.ReadLine();
        }
    }
}