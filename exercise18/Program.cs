using System;

namespace Exercise18Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            int lastDigit = num % 10;
            int firstDigit = num;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            Console.WriteLine("first digit is = {0}", firstDigit);
            Console.WriteLine("last digit is = {0}", lastDigit);

            Console.ReadKey();
        }
    }
}