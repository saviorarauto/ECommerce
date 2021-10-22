using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage ="Field {0} is required!")]
        [MaxLength(50, ErrorMessage ="This field accept until 50 characters!")]
        [Index("Department_Name_Index", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Company> Companies { get; set; } //Obs: Quando eu coloco Icollection de uma outra classe. Na verdade, eu estou dizendo que a classe atual será apresentada como lista dentro da classe que estou colocando em Iccolection
        public virtual ICollection<City> Cities { get; set; } //Nesse caso, o department será uma lista para Company e para City

        //Então, Department é lista tanto para Company quanto para City
    }
}