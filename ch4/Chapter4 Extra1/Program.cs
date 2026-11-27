using System;

namespace Chapter4_Extra1
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = null;
            try
            {
                Console.WriteLine(studentName.ToUpper());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException Caught: Object reference is null.");
                Console.WriteLine("Message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("NullReferenceException check complete.");
            }
            Console.ReadKey();
        }
    }
}