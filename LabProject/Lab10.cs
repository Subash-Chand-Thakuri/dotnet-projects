// using System;
// using System.Collections;  // For Non-Generic Collection
// using System.Collections.Generic; // For Generic Collection

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("=== Non-Generic Collection (ArrayList) ===");

//         // Non-Generic Collection (ArrayList)
//         ArrayList nonGenericList = new ArrayList();
//         nonGenericList.Add(10);
//         nonGenericList.Add("Hello");   // Mixed data types allowed
//         nonGenericList.Add(25.75);

//         foreach (var item in nonGenericList)
//         {
//             Console.WriteLine(item);
//         }

//         Console.WriteLine("\n=== Generic Collection (List<int>) ===");

//         // Generic Collection (List<int>)
//         List<int> genericList = new List<int>();
//         genericList.Add(10);
//         genericList.Add(20);
//         genericList.Add(30);
        
//         foreach (int num in genericList)
//         {
//             Console.WriteLine(num);
//         }

//         Console.WriteLine("\n=== Generic Collection (Dictionary<string, int>) ===");

//         // Generic Dictionary Example
//         Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
//         ageDictionary.Add("Alice", 25);
//         ageDictionary.Add("Bob", 30);
//         ageDictionary["Charlie"] = 28; // Alternative way to add key-value pair

//         foreach (var kvp in ageDictionary)
//         {
//             Console.WriteLine($"{kvp.Key} - {kvp.Value}");
//         }

//         Console.WriteLine("\nLab: 10");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
