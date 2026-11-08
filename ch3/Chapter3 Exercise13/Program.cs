using System;

namespace Chapter3_Exercise13
{
    abstract class Shape
    {
        protected double width;
        protected double height;

        public Shape(double w, double h)
        {
            width = w;
            height = h;
        }

        public abstract double CalculateSurface();
    }

    class Rectangle : Shape
    {
        public Rectangle(double w, double h) : base(w, h) { }

        public override double CalculateSurface()
        {
            return height * width;
        }
    }

    class Triangle : Shape
    {
        public Triangle(double w, double h) : base(w, h) { }

        public override double CalculateSurface()
        {
            return (height * width) / 2.0;
        }
    }

    class Circle : Shape
    {
        // Initializes both width and height with the same value (the radius)
        public Circle(double radius) : base(radius, radius) { }

        public override double CalculateSurface()
        {
            return Math.PI * width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape rect = new Rectangle(10, 5);
            Shape tri = new Triangle(10, 5);
            Shape circ = new Circle(4);

            Console.WriteLine("--- Shape Areas ---");
            Console.WriteLine("Rectangle Area (10 x 5):     {0:F2}", rect.CalculateSurface());
            Console.WriteLine("Triangle Area (10 x 5 / 2):  {0:F2}", tri.CalculateSurface());
            Console.WriteLine("Circle Area (radius = 4):    {0:F2}", circ.CalculateSurface());

            Console.ReadKey();
        }
    }
}