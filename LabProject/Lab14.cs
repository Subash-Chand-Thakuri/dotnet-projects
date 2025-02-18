// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Lambda Expression to find square of a number
//         Func<int, int> square = x => x * x;
//         Console.WriteLine("Square of 5: " + square(5));

//         // List of numbers
//         List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//         // LINQ with Lambda: Get even numbers
//         var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
//         Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

//         // LINQ with Lambda: Find sum of all numbers
//         int sum = numbers.Sum(n => n);
//         Console.WriteLine("Sum of all numbers: " + sum);

//         Console.WriteLine("\nLab: 14");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
