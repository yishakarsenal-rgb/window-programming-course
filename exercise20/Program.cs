using System;

namespace Exercise20Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number: ");
            int num = int.Parse(Console.ReadLine());

            int originalNum = num;
            int product = (num == 0) ? 0 : 1;

            while (num > 0)
            {
                product *= (num % 10);
                num /= 10;
            }

            Console.WriteLine("The product of digits of {0} is: {1}", originalNum, product);

            Console.ReadKey();
        }
    }
}