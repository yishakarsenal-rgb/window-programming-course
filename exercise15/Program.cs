using System;

namespace Exercise15Application
{
    class Program
    {
        static string ReturnEvenNumbers()
        {
            string result = "";
            for (int i = 2; i < 100; i += 2)
            {
                result += i + " ";
            }
            return result.Trim();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReturnEvenNumbers());

            Console.ReadKey();
        }
    }
}