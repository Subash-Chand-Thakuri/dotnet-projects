namespace CrudAppADO.Models
{
   public class Employee
{
    public int Id { get; set; }
    public required string Name { get; set; }  // Option 2: Required modifier (C# 11+)
    public int Age { get; set; }
    public required string Department { get; set; } // Option 2: Required modifier
}

}
