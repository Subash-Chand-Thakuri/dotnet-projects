// using System;

// // 1️⃣ Defining a Delegate
// delegate void MyDelegate(string message);

// // 2️⃣ Defining a Delegate for Multicast
// delegate void MulticastDelegateExample();

// class Program
// {
//     // Method for delegate example
//     public static void ShowMessage(string message)
//     {
//         Console.WriteLine("Delegate Example: " + message);
//     }

//     // Methods for multicast delegate example
//     public static void MethodOne()
//     {
//         Console.WriteLine("Method One executed!");
//     }

//     public static void MethodTwo()
//     {
//         Console.WriteLine("Method Two executed!");
//     }

//     static void Main()
//     {
//         // 3️⃣ Using a Delegate
//         MyDelegate del = ShowMessage;
//         del("Hello from Delegate!");

//         Console.WriteLine("\n-----------------\n");

//         // 4️⃣ Multicast Delegate (Adding multiple methods)
//         MulticastDelegateExample multiDel = MethodOne;
//         multiDel += MethodTwo; // Adding another method
//         multiDel(); // Both methods will execute

//         Console.WriteLine("\n-----------------\n");

//         // 5️⃣ Func Delegate (Returns a value)
//         Func<int, int, int> addFunc = (x, y) => x + y;
//         Console.WriteLine("Func Delegate Example (Addition): " + addFunc(5, 10));

//         Console.WriteLine("\n-----------------\n");

//         // 6️⃣ Action Delegate (Performs an action)
//         Action<string> printMessage = msg => Console.WriteLine("Action Delegate Example: " + msg);
//         printMessage("Hello from Action Delegate!");

//         Console.WriteLine("\n-----------------\n");

//         // 7️⃣ Anonymous Method (Using delegate keyword)
//         MyDelegate anonymousDel = delegate (string msg)
//         {
//             Console.WriteLine("Anonymous Method Example: " + msg);
//         };
//         anonymousDel("Hello from Anonymous Method!");

//         Console.WriteLine("\n-----------------\n");

//         // 8️⃣ Event Example
//         EventExample eventExample = new EventExample();
//         eventExample.Notify += EventHandlerMethod; // Subscribing to event
//         eventExample.TriggerEvent("Event Triggered!");

//         Console.WriteLine("\nLab: 9");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }

//     // Method for Event Handling
//     public static void EventHandlerMethod(string eventMessage)
//     {
//         Console.WriteLine("Event Received: " + eventMessage);
//     }
// }

// // 9️⃣ Event Example
// class EventExample
// {
//     // Declaring an event using a delegate
//     public event Action<string> Notify;

//     // Method to trigger event
//     public void TriggerEvent(string msg)
//     {
//         if (Notify != null)
//         {
//             Notify(msg);
//         }
//     }
// }
