using System;

namespace Chapter3_Exercise4
{
    class Circle
    {
        private double radius;
        private string color;

        // Default constructor
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        // Overloaded constructor taking radius
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        public double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public double getArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class TestCircle
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("default circle with radius = 1");
            Console.WriteLine("Perimeter: {0:F2}", c1.getPerimeter());
            Console.WriteLine("Area:      {0:F2}", c1.getArea());
            Circle c2 = new Circle(5.0);
            Console.WriteLine("\nsecond circle with radius = 5");
            Console.WriteLine("Perimeter: {0:F2}", c2.getPerimeter());
            Console.WriteLine("Area:      {0:F2}", c2.getArea());
            Console.ReadKey();
        }
    }
}