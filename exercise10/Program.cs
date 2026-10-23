using System;

namespace Exercise10Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // problems with using while (start != num) causes an infinite loop if num is odd or negative,
            // because start increments by 2 (0, 2, 4, 6...) and never equals an odd number.

            // fixed code
            Console.Write("enter positive number ");
            int num = int.Parse(Console.ReadLine());
            int start = 0;

            while (start + 2 <= num)
            {
                start += 2;
                Console.WriteLine(start);
            }

            Console.ReadKey();
        }
    }
}