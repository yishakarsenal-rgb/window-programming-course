using System;
namespace Chapter3_Exercise7
{
    class Program7
    {
        private double length;
        private double width;
        public void setLength(double l)
        {
            length = l;
        }
        public double getLength()
        {
            return length;
        }
        public void setWidth(double w)
        {
            width = w;
        }
        public double getWidth()
        {
            return width;
        }
        public double caculateArea()
        {
            return length * width;
        }
    }
    class TestProgram7
    {
        static void Main(string[] args)
        {
            Program7 rect = new Program7();
            Console.Write("enter length= ");
            rect.setLength(Convert.ToDouble(Console.ReadLine()));
            Console.Write("enter width= ");
            rect.setWidth(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("area of the rectangle= {0}", rect.caculateArea());
            Console.ReadKey();
        }
    }
}