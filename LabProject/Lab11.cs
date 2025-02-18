// using System;

// // Generic class with a generic field and method
// class GenericContainer<T>
// {
//     // Generic field
//     private T data;

//     // Constructor to initialize the generic field
//     public GenericContainer(T value)
//     {
//         data = value;
//     }

//     // Generic Method to display the value
//     public void Display()
//     {
//         Console.WriteLine("Stored Value: " + data);
//     }

//     // Generic Method to get the value
//     public T GetValue()
//     {
//         return data;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Using Generic Class with int
//         GenericContainer<int> intContainer = new GenericContainer<int>(100);
//         intContainer.Display();
//         Console.WriteLine("Retrieved Value: " + intContainer.GetValue());

//         // Using Generic Class with string
//         GenericContainer<string> stringContainer = new GenericContainer<string>("Hello, Generics!");
//         stringContainer.Display();
//         Console.WriteLine("Retrieved Value: " + stringContainer.GetValue());

//         Console.WriteLine("\nLab: 11");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
