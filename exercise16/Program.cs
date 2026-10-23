using System;

namespace Exercise16Application
{
    class Program
    {
        static bool IfNumberContains3(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("IfNumberContains3(7201432) -> {0}", IfNumberContains3(7201432));
            Console.WriteLine("IfNumberContains3(87501)   -> {0}", IfNumberContains3(87501));

            Console.ReadKey();
        }
    }
}