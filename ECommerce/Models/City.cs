using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Field {0} is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field {0} is required!")]
        [Range(1, double.MaxValue, ErrorMessage ="Select a Department!")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}