using System;

namespace Chapter4_Extra6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter HTTP status error code (e.g., 404 or 500): ");
                int code = int.Parse(Console.ReadLine());
                throw new Exception(code.ToString());
            }
            catch (Exception ex) when (ex.Message == "404")
            {
                Console.WriteLine("Client Error (404): Requested resource not found.");
            }
            catch (Exception ex) when (ex.Message == "500")
            {
                Console.WriteLine("Server Error (500): Internal server failure.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Other Error Code: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}