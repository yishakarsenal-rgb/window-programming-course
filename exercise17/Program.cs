using System;

namespace Exercise17Application
{
    class Program
    {
        static int DigitsSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("5434 = {0}", DigitsSum(5434));
            Console.WriteLine("904861 = {0}", DigitsSum(904861));

            Console.ReadKey();
        }
    }
}