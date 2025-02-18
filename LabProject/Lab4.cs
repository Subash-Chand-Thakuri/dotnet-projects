// using System;

// // Class with indexer using int type
// class NumberCollection
// {
//     private int[] numbers = new int[5];  // Array of integers

//     // Indexer with int type
//     public int this[int index]
//     {
//         get
//         {
//             if (index >= 0 && index < numbers.Length)
//                 return numbers[index];
//             else
//                 throw new IndexOutOfRangeException("Index is out of range.");
//         }
//         set
//         {
//             if (index >= 0 && index < numbers.Length)
//                 numbers[index] = value;
//             else
//                 throw new IndexOutOfRangeException("Index is out of range.");
//         }
//     }
// }

// // Class with indexer using string type (custom indexing)
// class StringDictionary
// {
//     private string[] words = new string[5];  // Array of strings

//     // Indexer with string type
//     public string this[string key]
//     {
//         get
//         {
//             for (int i = 0; i < words.Length; i++)
//             {
//                 if (words[i] != null && words[i].Equals(key))
//                     return words[i];
//             }
//             return null;  // Return null if not found
//         }
//         set
//         {
//             for (int i = 0; i < words.Length; i++)
//             {
//                 if (words[i] == null)
//                 {
//                     words[i] = key;
//                     break;
//                 }
//             }
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Demonstrating Indexer with int type
//         NumberCollection collection = new NumberCollection();
//         collection[0] = 10;
//         collection[1] = 20;
//         collection[2] = 30;
//         collection[3] = 40;
//         collection[4] = 50;

//         Console.WriteLine("Number Collection using int indexer:");
//         for (int i = 0; i < 5; i++)
//         {
//             Console.WriteLine($"Element at index {i}: {collection[i]}");
//         }

//         // Demonstrating Indexer with string type
//         StringDictionary dictionary = new StringDictionary();
//         dictionary["apple"] = "fruit";
//         dictionary["carrot"] = "vegetable";
//         dictionary["dog"] = "animal";

//         Console.WriteLine("\nString Dictionary using string indexer:");
//         Console.WriteLine($"apple is a {dictionary["apple"]}");
//         Console.WriteLine($"carrot is a {dictionary["carrot"]}");
//         Console.WriteLine($"dog is a {dictionary["dog"]}");

//         Console.WriteLine("\nLab: 4");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
