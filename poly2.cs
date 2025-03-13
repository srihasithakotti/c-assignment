using System;

// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class - Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Derived class - Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        // Runtime polymorphism using method overriding
        Animal myAnimal;
        
        myAnimal = new Dog();
        myAnimal.MakeSound(); // Outputs: Dog barks
        
        myAnimal = new Cat();
        myAnimal.MakeSound(); // Outputs: Cat meows
    }
}