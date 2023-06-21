using System.ComponentModel.DataAnnotations;

namespace BlogApi.DataAccesLayer
{
    public class Employee
    {
        [Key]
        public int ID { get; set; } 
        public string? Name { get; set; } 
    }
}
