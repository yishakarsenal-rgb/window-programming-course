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
            // int 2pac = 6; // not correct
            // int new;      // not correct

            Console.WriteLine("--- Valid Identifiers Output ---");
            Console.WriteLine("Class: {0}", Class);
            Console.WriteLine("_2pac: {0}", _2pac);
            Console.WriteLine("greeting: {0}", greeting);
            Console.WriteLine("numberOfClients: {0}", numberOfClients);
            Console.ReadKey();
        }
    }
}