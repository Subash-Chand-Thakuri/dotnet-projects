// using System;

// class Employee
// {
//     // Auto-Implemented Property
//     public string Name { get; set; }  // Getter and Setter are automatically implemented

//     // Read-Only Property
//     public int EmployeeId { get; }

//     // Constructor to initialize the Read-Only Property
//     public Employee(int employeeId, string name)
//     {
//         EmployeeId = employeeId;  // Read-Only Property can be set inside the constructor
//         Name = name;  // Auto Property is set using the setter
//     }

//     // Display employee details
//     public void DisplayDetails()
//     {
//         Console.WriteLine($"Employee ID: {EmployeeId}, Name: {Name}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Creating an instance of Employee class
//         Employee employee = new Employee(101, "John Doe");

//         // Accessing the Auto Property (Name)
//         Console.WriteLine("Before Change:");
//         employee.DisplayDetails();

//         // Modifying the Auto Property
//         employee.Name = "Jane Smith";

//         // Accessing the Read-Only Property (EmployeeId)
//         Console.WriteLine("\nAfter Name Change:");
//         employee.DisplayDetails();

//         // The following line would result in an error because EmployeeId is a Read-Only Property
//         // employee.EmployeeId = 102;  // ❌ Not allowed: Read-only property cannot be modified outside the constructor

//          Console.WriteLine("\nLab: 2");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
