using System;

namespace Exercise27Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter string = ");
            string str = Console.ReadLine();

            Console.Write("characters of the string in reverse are = ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", str[i]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}