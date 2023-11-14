using System.ComponentModel.DataAnnotations;

namespace ifood_core_mvc.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }

        public DateTime DayofBird { get; set; }

    }
}
