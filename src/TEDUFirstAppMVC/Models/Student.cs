using System.ComponentModel.DataAnnotations;

namespace TEDUFirstAppMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Class Class { get; set; } 
    }
}
