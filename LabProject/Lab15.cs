// using System;

// // Custom Exception Class
// class CustomException : Exception
// {
//     public CustomException(string message) : base(message) { }
// }

// class Program
// {
//     static void Divide(int a, int b)
//     {
//         if (b == 0)
//         {
//             throw new DivideByZeroException("Cannot divide by zero!"); // Using throw keyword
//         }
//         Console.WriteLine($"Result: {a / b}");
//     }

//     static void CheckNumber(int num)
//     {
//         if (num < 0)
//         {
//             throw new CustomException("Negative numbers are not allowed!"); // Throwing custom exception
//         }
//         Console.WriteLine($"Valid number: {num}");
//     }

//     static void Main()
//     {
//         try
//         {
//             Console.Write("Enter numerator: ");
//             int num1 = Convert.ToInt32(Console.ReadLine());

//             Console.Write("Enter denominator: ");
//             int num2 = Convert.ToInt32(Console.ReadLine());

//             Divide(num1, num2);
//         }
//         catch (DivideByZeroException ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//         finally
//         {
//             Console.WriteLine("Division attempt finished.");
//         }

//         try
//         {
//             Console.Write("\nEnter a number to check: ");
//             int number = Convert.ToInt32(Console.ReadLine());
//             CheckNumber(number);
//         }
//         catch (CustomException ex)
//         {
//             Console.WriteLine($"Custom Exception: {ex.Message}");
//         }
//         finally
//         {
//             Console.WriteLine("Number validation attempt finished.");
//         }

//         Console.WriteLine("\nLab: 15");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
