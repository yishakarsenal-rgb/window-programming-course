using System;

namespace Chapter4_Extra9_NestedTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 85, 90, 78 };

            try
            {
                Console.Write("Enter student index (0-2): ");
                int index = int.Parse(Console.ReadLine());

                try
                {
                    Console.WriteLine("Grade: " + grades[index]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Inner Catch: Index must be 0, 1, or 2.");
                }
                finally
                {
                    Console.WriteLine("Inner finally: Array lookup finished.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Outer Catch: Invalid number format entered.");
            }
            finally
            {
                Console.WriteLine("Outer finally: Program finished.");
            }

            Console.ReadKey();
        }
    }
}