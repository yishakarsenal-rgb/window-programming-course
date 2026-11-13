using System;
namespace Chapter3_Exercise3
{
    class Program3
    {
        public int number1;
        public int number2;
        public Program3(int n1, int n2)
        {
            number1 = n1;
            number2 = n2;
        }
        public bool checkIf5()
        {
            return (number1 == 5 || number2 == 5 || (number1 + number2) == 5 || Math.Abs(number1 - number2) == 5);
        }
    }
    class TestProgram3
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number= ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number= ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Program3 obj = new Program3(n1, n2);
            Console.WriteLine(obj.checkIf5());
            Console.ReadKey();
        }
    }
}