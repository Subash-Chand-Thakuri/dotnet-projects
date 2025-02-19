namespace SimpleEfWebApi.Models
{
    public class Employee
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Department { get; set; } = string.Empty;
    }
}
