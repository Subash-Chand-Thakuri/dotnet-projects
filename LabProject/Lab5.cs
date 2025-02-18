// using System;

// // Base class
// class Animal
// {
//     // Field in the base class
//     protected string name;

//     // Constructor of the base class
//     public Animal(string name)
//     {
//         this.name = name;
//         Console.WriteLine("Animal Constructor Called!");
//     }

//     // Method in the base class
//     public void Speak()
//     {
//         Console.WriteLine("Animal speaks!");
//     }

//     // Method that can be overridden in the derived class
//     public virtual void Move()
//     {
//         Console.WriteLine("Animal moves!");
//     }
// }

// // Derived class
// class Dog : Animal
// {
//     // Constructor of the derived class calling the base class constructor
//     public Dog(string name) : base(name)  // Using base() to call the base class constructor
//     {
//         Console.WriteLine("Dog Constructor Called!");
//     }

//     // Method in the derived class that overrides the base class method
//     public override void Move()
//     {
//         Console.WriteLine("Dog runs!");
//     }

//     // Method to demonstrate using base to call the base class method
//     public void CallBaseMove()
//     {
//         base.Move();  // Calling the base class method using base
//     }

//     // Method to demonstrate using base to access base class field
//     public void AccessBaseField()
//     {
//         Console.WriteLine("The dog's name is: " + base.name);  // Accessing base class field using base
//     }

//     // This method is unnecessary and will not work because base constructor is already called in the derived class constructor
//     // public void CallBaseConstructor()
//     // {
//     //     base("Some Animal Name");  // This line will cause a compile-time error because the base constructor has already been called
//     // }
// }

// class Program
// {
//     static void Main()
//     {
//         // Creating an object of the derived class
//         Dog myDog = new Dog("Buddy");

//         // Demonstrating the use of base keyword to access base class fields
//         myDog.AccessBaseField();

//         // Demonstrating the use of base keyword to call base class methods
//         myDog.CallBaseMove();

//         // The following line is commented out because it would cause an error
//         // myDog.CallBaseConstructor();

//         Console.WriteLine("\nLab: 5");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
