using System;

namespace Exercise4Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter grade = ");
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 90 && grade < 101)
            {
                Console.WriteLine("grade= A");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("grade= B");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("grade= C");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("grade= D");
            }
            else
            {
                Console.WriteLine("grade= F");
            }

            Console.ReadKey();
        }
    }
}