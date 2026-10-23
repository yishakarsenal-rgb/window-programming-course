using System;

namespace Exercise19Application
{
    class Program
    {
        static int NumberOfEvenDigits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    count++;
                }
                num /= 10;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("7201432 = {0}", NumberOfEvenDigits(7201432));
            Console.WriteLine("97511 = {0}", NumberOfEvenDigits(97511));

            Console.ReadKey();
        }
    }
}