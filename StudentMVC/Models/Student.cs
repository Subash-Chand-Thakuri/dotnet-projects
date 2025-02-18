using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Student ID is required")]
        public int StdID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Faculty is required")]
        public string Faculty { get; set; }
    }
}
