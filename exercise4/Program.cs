using System;

namespace Exercise4Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numeric grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 90 && grade < 101)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else
            {
                Console.WriteLine("Letter Grade: F");
            }

            Console.ReadKey();
        }
    }
}