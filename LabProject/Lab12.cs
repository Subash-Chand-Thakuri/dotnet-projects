// using System;
// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         string filePath = "Lab12UserInput.txt";  // File where input will be saved

//         Console.WriteLine("Enter text to save in the file (Type 'exit' to stop):");

//         using (StreamWriter writer = new StreamWriter(filePath, true)) // Append mode
//         {
//             while (true)
//             {
//                 string userInput = Console.ReadLine();

//                 if (userInput.ToLower() == "exit") // Stop condition
//                     break;

//                 writer.WriteLine(userInput);
//             }
//         }

//         Console.WriteLine($"Your input has been saved in {filePath}");

//         Console.WriteLine("\nLab: 12");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
