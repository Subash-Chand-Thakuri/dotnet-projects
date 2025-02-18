using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start: Main Method");

        // Call an asynchronous method
        await PerformTaskAsync();

        Console.WriteLine("End: Main Method");

        Console.WriteLine("\nLab: 16");
        Console.WriteLine("Name: Subash Chand Thakuri");
        Console.WriteLine("Roll No: 62/078 B (28119)");
    }

    // Asynchronous method
    static async Task PerformTaskAsync()
    {
        Console.WriteLine("Task Started...");
        
        // Simulating delay (e.g., API call, file I/O)
        await Task.Delay(3000);

        Console.WriteLine("Task Completed!");
    }
}
