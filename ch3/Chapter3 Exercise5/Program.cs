using System;
namespace Chapter3_Exercise5
{
    class Program5
    {
        public int number1;
        public int number2;
        public int number3;
        public Program5(int n1, int n2, int n3)
        {
            number1 = n1;
            number2 = n2;
            number3 = n3;
        }
        public bool checkIfPossible()
        {
            return (number1 + number2 == number3) ||
                   (number1 + number3 == number2) ||
                   (number2 + number3 == number1);
        }
    }
    class TestProgram5
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number= ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number= ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third number= ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Program5 obj = new Program5(n1, n2, n3);
            Console.WriteLine(obj.checkIfPossible());
            Console.ReadKey();
        }
    }
}