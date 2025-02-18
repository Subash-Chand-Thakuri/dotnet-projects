// using System;

// // (a) Abstract Class Example
// abstract class Animal
// {
//     public string Name { get; set; }  // Property

//     public Animal(string name)
//     {
//         Name = name;
//     }

//     public abstract void MakeSound();  // Abstract method

//     public void Display()
//     {
//         Console.WriteLine($"Animal Name: {Name}");
//     }
// }

// // Derived class implementing abstract class
// class Dog : Animal
// {
//     public Dog(string name) : base(name) { }

//     public override void MakeSound()
//     {
//         Console.WriteLine("Dog barks: Woof Woof!");
//     }
// }

// // (b) Interface Example
// interface IVehicle
// {
//     void Start();  // Method signature
// }

// // Class implementing interface
// class Car : IVehicle
// {
//     public void Start()
//     {
//         Console.WriteLine("Car is starting with a key...");
//     }
// }

// // (c) Multiple Inheritance using Interfaces
// interface IFlyable
// {
//     void Fly();
// }

// interface ISwimmable
// {
//     void Swim();
// }

// // Class implementing multiple interfaces
// class Duck : IFlyable, ISwimmable
// {
//     public void Fly()
//     {
//         Console.WriteLine("Duck is flying...");
//     }

//     public void Swim()
//     {
//         Console.WriteLine("Duck is swimming...");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // (a) Abstract Class
//         Console.WriteLine("\n=== Abstract Class Example ===");
//         Animal myDog = new Dog("Buddy");
//         myDog.Display();
//         myDog.MakeSound();

//         // (b) Interface Example
//         Console.WriteLine("\n=== Interface Example ===");
//         IVehicle myCar = new Car();
//         myCar.Start();

//         // (c) Multiple Inheritance using Interfaces
//         Console.WriteLine("\n=== Multiple Inheritance using Interfaces ===");
//         Duck myDuck = new Duck();
//         myDuck.Fly();
//         myDuck.Swim();

//         // Lab Details
//         Console.WriteLine("\nLab: 7");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
