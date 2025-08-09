using System;

namespace AbstractDemo
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class 1
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class 2
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
        }
    }
}
