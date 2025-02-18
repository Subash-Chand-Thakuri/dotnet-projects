// using System;

// // Base class
// class Parent
// {
//     // Virtual method for method overriding
//     public virtual void Show()
//     {
//         Console.WriteLine("Parent's Show() - Method Overriding Example");
//     }

//     // Non-virtual method for method hiding
//     public void Display()
//     {
//         Console.WriteLine("Parent's Display() - Method Hiding Example");
//     }
// }

// // Derived class
// class Child : Parent
// {
//     // Method Overriding (Dynamic Polymorphism)
//     public override void Show()
//     {
//         Console.WriteLine("Child's Show() - Overriding Parent's Show()");
//     }

//     // Method Hiding (Shadowing)
//     public new void Display()
//     {
//         Console.WriteLine("Child's Display() - Hiding Parent's Display()");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("-----Method Overriding and Method Hiding-----\n");

//         Parent parentObj = new Parent();
//         Child childObj = new Child();
//         Parent parentRef = new Child(); // Dynamic polymorphism using base class reference

//         Console.WriteLine("Calling methods using Parent object:");
//         parentObj.Show();    // Calls Parent's Show()
//         parentObj.Display(); // Calls Parent's Display()

//         Console.WriteLine("\nCalling methods using Child object:");
//         childObj.Show();    // Calls Child's overridden Show()
//         childObj.Display(); // Calls Child's hidden Display()

//         Console.WriteLine("\nCalling methods using Parent reference to Child:");
//         parentRef.Show();    // Calls Child's overridden Show() (dynamic polymorphism)
//         parentRef.Display(); // Calls Parent's Display() (method hiding)

//         Console.WriteLine("\nLab: 6");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
