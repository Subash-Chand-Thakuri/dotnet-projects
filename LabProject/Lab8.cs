// using System;

// // Enumeration to represent different departments
// enum Department
// {
//     ComputerScience,
//     Electrical,
//     Mechanical,
//     Civil
// }

// // Structure to hold student information
// struct Student
// {
//     public int Id;
//     public string Name;
//     public Department Dept; // Enum as a field

//     // Constructor to initialize the struct
//     public Student(int id, string name, Department dept)
//     {
//         Id = id;
//         Name = name;
//         Dept = dept;
//     }

//     // Method to display student details
//     public void Display()
//     {
//         Console.WriteLine($"Student ID: {Id}");
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Department: {Dept}");
//     }
// }

// // Partial Class (Part 1)
// partial class Person
// {
//     public string FirstName { get; set; }
// }

// // Partial Class (Part 2)
// partial class Person
// {
//     public string LastName { get; set; }

//     public void ShowFullName()
//     {
//         Console.WriteLine($"Full Name: {FirstName} {LastName}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Using Struct
//         Student student1 = new Student(101, "Subash Chand Thakuri", Department.ComputerScience);
//         student1.Display();

//         Console.WriteLine("\n-----------------\n");

//         // Using Partial Class
//         Person person1 = new Person();
//         person1.FirstName = "Subash";
//         person1.LastName = "Chand Thakuri";
//         person1.ShowFullName();

//         Console.WriteLine("\nLab: 8");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
