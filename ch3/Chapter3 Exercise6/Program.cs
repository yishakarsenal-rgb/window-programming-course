using System;
namespace Chapter3_Exercise6
{
    class Program6
    {
        public int number1;
        public int number2;
        public int number3;
        public Program6(int n1, int n2, int n3)
        {
            number1 = n1;
            number2 = n2;
            number3 = n3;
        }
        public bool checkRigtmostDigit()
        {
            int d1 = number1 % 10;
            int d2 = number2 % 10;
            int d3 = number3 % 10;
            return (d1 == d2) || (d1 == d3) || (d2 == d3);
        }
    }
    class TestProgram6
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number= ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number= ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter third number= ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Program6 obj = new Program6(n1, n2, n3);
            Console.WriteLine(obj.checkRigtmostDigit());
            Console.ReadKey();
        }
    }
}