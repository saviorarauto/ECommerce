using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Company
    {
        [Key]
        public int CompanytId { get; set; }

        [Required(ErrorMessage = "Field {0} is required!")]
        [MaxLength(50, ErrorMessage = "This field accept until 50 characters!")]
        [Index("Company_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field {0} is required!")]
        [MaxLength(50, ErrorMessage = "This field accept until 50 characters!")]
        [Display(Name="Telephone")]
        [Index("Phone_Number_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Field {0} is required!")]
        [MaxLength(100, ErrorMessage = "This field accept until 50 characters!")]
        [Display(Name = "Adress")]
        public string Address { get; set; }

        [Display(Name="Image")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Field {0} is required!")]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Field {0} is required!")]
        public int CityId { get; set; }


        public virtual Department Departments { get; set; } //Porém, Company não é uma lista para Department
        public virtual City Cities { get; set; } //Porém, Company não é uma lista para City


    }
}