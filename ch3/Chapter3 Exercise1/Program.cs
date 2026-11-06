using System;
namespace Chapter3_Exercise1
{
    class House
    {
        private double length;
        private double width;
        private double area;

        public House(double l, double w)
        {
            length = l;
            width = w;
            area = length * width;
        }

        public void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2", area);
        }
    }

    class TestClass
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the house: ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the house: ");
            double w = Convert.ToDouble(Console.ReadLine());

            House myHouse = new House(l, w);
            myHouse.ShowData();

            Console.ReadKey();
        }
    }
}