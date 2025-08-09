using System;

namespace InterfaceDemo
{
    // Interface
    interface IMovable
    {
        void Move();
    }

    // Implementing class 1
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Implementing class 2
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();       // Car is moving
            bicycle.Move();   // Bicycle is moving
        }
    }
}
