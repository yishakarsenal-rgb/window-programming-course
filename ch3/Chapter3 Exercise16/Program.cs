using System;

namespace Chapter3_Exercise16
{
    abstract class Marks
    {
        public abstract double getPercentage();
    }

    class A : Marks
    {
        private double mark1, mark2, mark3;

        public A(double m1, double m2, double m3)
        {
            mark1 = m1;
            mark2 = m2;
            mark3 = m3;
        }

        public override double getPercentage()
        {
            return (mark1 + mark2 + mark3) / 3.0;
        }
    }

    class B : Marks
    {
        private double mark1, mark2, mark3, mark4;

        public B(double m1, double m2, double m3, double m4)
        {
            mark1 = m1;
            mark2 = m2;
            mark3 = m3;
            mark4 = m4;
        }

        public override double getPercentage()
        {
            return (mark1 + mark2 + mark3 + mark4) / 4.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A studentA = new A(85, 90, 92);
            B studentB = new B(78, 88, 94, 84);

            Console.WriteLine("Student A Percentage (3 subjects): {0:F2}%", studentA.getPercentage());
            Console.WriteLine("Student B Percentage (4 subjects): {0:F2}%", studentB.getPercentage());

            Console.ReadKey();
        }
    }
}