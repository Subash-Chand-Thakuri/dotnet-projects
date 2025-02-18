// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Sample List of numbers
//         List<int> numbers = new List<int> { 10, 25, 3, 7, 45, 30, 15, 60 };

//         // LINQ Query to get even numbers
//         var evenNumbers = from num in numbers
//                           where num % 2 == 0
//                           orderby num ascending
//                           select num;

//         Console.WriteLine("Even numbers in ascending order:");
//         foreach (var num in evenNumbers)
//         {
//             Console.Write(num + " ");
//         }

//         Console.WriteLine("\n");

//         // LINQ Method Syntax to filter numbers greater than 10
//         var greaterThanTen = numbers.Where(n => n > 10).OrderByDescending(n => n).ToList();

//         Console.WriteLine("Numbers greater than 10 in descending order:");
//         greaterThanTen.ForEach(n => Console.Write(n + " "));

//         Console.WriteLine("\n");

//         // LINQ to find the first number greater than 30
//         int firstNumber = numbers.First(n => n > 30);
//         Console.WriteLine($"First number greater than 30: {firstNumber}");

//         Console.WriteLine("\n");

//         // LINQ on strings
//         List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
//         var filteredNames = names.Where(name => name.Length > 3).OrderBy(name => name);

//         Console.WriteLine("Names with more than 3 characters:");
//         foreach (var name in filteredNames)
//         {
//             Console.Write(name + " ");
//         }

//         Console.WriteLine("\n\nLab: 13");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
