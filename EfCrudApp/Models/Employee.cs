namespace EfCrudApp.Models
{
    public class Employee
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Department { get; set; } = string.Empty;
    }
}
