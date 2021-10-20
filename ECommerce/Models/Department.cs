using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage ="Field is required!")]
        public string Name { get; set; }
    }
}