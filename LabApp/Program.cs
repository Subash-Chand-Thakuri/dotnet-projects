using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using var context = new LabDbContext();

        while (true)
        {
            Console.WriteLine("\nChoose an operation: 1-Insert, 2-Read, 3-Update, 4-Delete, 5-Exit");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    InsertEmployee();
                    break;
                case "2":
                    ReadEmployees();
                    break;
                case "3":
                    UpdateEmployee();
                    break;
                case "4":
                    DeleteEmployee();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    static void InsertEmployee()
    {
        using var context = new LabDbContext();
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter Department: ");
        string department = Console.ReadLine();

        var employee = new Employee { Name = name, Age = age, Department = department };
        context.Employees.Add(employee);
        context.SaveChanges();
        Console.WriteLine("Employee Added.");
    }

    static void ReadEmployees()
    {
        using var context = new LabDbContext();
        var employees = context.Employees.ToList();
        Console.WriteLine("\nEmployees List:");
        employees.ForEach(e => Console.WriteLine($"{e.Id}: {e.Name}, {e.Age}, {e.Department}"));
    }

    static void UpdateEmployee()
    {
        using var context = new LabDbContext();
        Console.Write("Enter Employee ID to update: ");
        int id = int.Parse(Console.ReadLine());
        var employee = context.Employees.Find(id);

        if (employee != null)
        {
            Console.Write("Enter New Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Enter New Age: ");
            employee.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter New Department: ");
            employee.Department = Console.ReadLine();

            context.SaveChanges();
            Console.WriteLine("Employee Updated.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    static void DeleteEmployee()
    {
        using var context = new LabDbContext();
        Console.Write("Enter Employee ID to delete: ");
        int id = int.Parse(Console.ReadLine());
        var employee = context.Employees.Find(id);

        if (employee != null)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
            Console.WriteLine("Employee Deleted.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
