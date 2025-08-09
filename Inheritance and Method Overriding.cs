using System;

namespace InheritanceDemo
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class 1
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class 2
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            genericAnimal.MakeSound(); // Some generic sound
            dog.MakeSound();           // Bark
            cat.MakeSound();           // Meow
        }
    }
}
