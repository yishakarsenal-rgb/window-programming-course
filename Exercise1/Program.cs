using System;

namespace Exercise1Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int Class = 2;
            int _2pac = 0;
            string greeting = "Hello";
            int numberOfClients = 100;

            // Invalid Identifiers (commented out so the program builds without errors):
            // int 2pac = 6; // Invalid: Cannot start with a number
            // int new;      // Invalid: 'new' is a C# reserved keyword

            Console.WriteLine("--- Valid Identifiers Output ---");
            Console.WriteLine("Class: {0}", Class);
            Console.WriteLine("_2pac: {0}", _2pac);
            Console.WriteLine("greeting: {0}", greeting);
            Console.WriteLine("numberOfClients: {0}", numberOfClients);

            Console.ReadKey();
        }
    }
}