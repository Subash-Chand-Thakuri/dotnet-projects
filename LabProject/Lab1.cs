// using System;

// class ConstructorDemo
// {
//     // 1. Default Constructor
//     public ConstructorDemo()
//     {
//         Console.WriteLine("Default Constructor Called!");
//     }

//     // 2. Parameterized Constructor
//     public ConstructorDemo(string message)
//     {
//         Console.WriteLine($"Parameterized Constructor: {message}");
//     }

//     // 3. Copy Constructor
//     public ConstructorDemo(ConstructorDemo obj)
//     {
//         Console.WriteLine("Copy Constructor Called!");
//     }

//     // 4. Static Constructor
//     static ConstructorDemo()
//     {
//         Console.WriteLine("Static Constructor Called!");
//     }

//     // 5. Private Constructor (Singleton Example)
//     private ConstructorDemo(int x)
//     {
//         Console.WriteLine("Private Constructor Called!");
//     }

//     static void Main()
//     {
//         // Creating instances
//         ConstructorDemo obj1 = new ConstructorDemo();  // Default Constructor
//         ConstructorDemo obj2 = new ConstructorDemo("Hello from Parameterized Constructor!"); // Parameterized
//         ConstructorDemo obj3 = new ConstructorDemo(obj1); // Copy Constructor

//         // Static constructor runs only once before any object is created

//         // Cannot create object of Private Constructor
//         ConstructorDemo obj4 = new ConstructorDemo(10); // ❌ Not Allowed


//         Console.WriteLine("\nLab: 1");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
