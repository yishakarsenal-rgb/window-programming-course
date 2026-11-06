using System;
namespace Chapter3_Exercise8
{
    class Program8
    {
        public int number1;
        public int number2;
        public Program8(int n1, int n2)
        {
            number1 = n1;
            number2 = n2;
        }
        public int checkNearest()
        {
            if (number1 == number2)
                return 0;
            int diff1 = Math.Abs(100 - number1);
            int diff2 = Math.Abs(100 - number2);
            if (diff1 < diff2)
                return number1;
            else
                return number2;
        }
    }
    class TestProgram8
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number= ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter second number= ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Program8 obj = new Program8(n1, n2);
            Console.WriteLine(obj.checkNearest());
            Console.ReadKey();
        }
    }
}