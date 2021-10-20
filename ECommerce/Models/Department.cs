using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage ="Field {0} is required!")]
        public string Name { get; set; }
    }
}