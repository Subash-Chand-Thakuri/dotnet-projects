// using System;
// using System.Reflection;

// // ✅ Built-in Attribute: [Obsolete] and [Serializable]
// [Serializable] // Marks the class as serializable
// class DemoClass
// {
//     [Obsolete("This method is deprecated, use NewMethod instead.")] // Marks the method as obsolete
//     public void OldMethod()
//     {
//         Console.WriteLine("Old Method - Deprecated!");
//     }

//     public void NewMethod()
//     {
//         Console.WriteLine("New Method - Recommended!");
//     }
// }

// // ✅ Custom Attribute
// [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] // Can be used on Class and Method
// class CustomInfoAttribute : Attribute
// {
//     public string Info { get; }
//     public CustomInfoAttribute(string info)
//     {
//         Info = info;
//     }
// }

// // ✅ Applying Custom Attribute
// [CustomInfo("This is a sample class with a custom attribute.")]
// class SampleClass
// {
//     [CustomInfo("This is a sample method with a custom attribute.")]
//     public void Display()
//     {
//         Console.WriteLine("Executing SampleClass.Display() method.");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Using Built-in Attributes
//         DemoClass demo = new DemoClass();
//         demo.OldMethod(); // Will show a warning
//         demo.NewMethod();

//         // Using Reflection to Read Custom Attribute
//         Type type = typeof(SampleClass);
//         CustomInfoAttribute classAttr = (CustomInfoAttribute)Attribute.GetCustomAttribute(type, typeof(CustomInfoAttribute));
//         Console.WriteLine($"\nClass Attribute Info: {classAttr.Info}");

//         MethodInfo method = type.GetMethod("Display");
//         CustomInfoAttribute methodAttr = (CustomInfoAttribute)Attribute.GetCustomAttribute(method, typeof(CustomInfoAttribute));
//         Console.WriteLine($"Method Attribute Info: {methodAttr.Info}");

//         // Calling the method
//         SampleClass sample = new SampleClass();
//         sample.Display();

//         Console.WriteLine("\nLab: 16");
//         Console.WriteLine("Name: Subash Chand Thakuri");
//         Console.WriteLine("Roll No: 62/078 B (28119)");
//     }
// }
