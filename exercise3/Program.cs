using System;

namespace Exercise3Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10 / 3);
            Console.WriteLine(5.2 / 2.0);
            Console.WriteLine(9 % 3);

            int X = 2 * 5 / 3 + 3 * 5 + 7;

            Console.WriteLine("X = 2 * 5 / 3 + 3 * 5 + 7");
            Console.WriteLine("first (2 * 5)   = 10");
            Console.WriteLine("second (10 / 3)  = 3");
            Console.WriteLine("third (3 * 5)   = 15");
            Console.WriteLine("fourth (3 + 15)  = 18");
            Console.WriteLine("fifth (18 + 7)  = 25");
            Console.WriteLine("X = {0}", X);

            Console.ReadKey();
        }
    }
}