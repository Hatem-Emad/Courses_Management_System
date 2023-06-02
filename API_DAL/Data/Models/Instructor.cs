using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDay02_DAL.Validators;

namespace APIDay02_DAL.Data.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? SSN { get; set; }
        [StringLength(50)]
        public required string Name { get; set;}
        [Range(10_000, 50_000, ErrorMessage ="The {0} must be from {1} to {2}")]
        public  int Salary { get; set; }
        [Agefrom27to60]
        public int? Age { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [StringLength(50)]
        public string? Email { get; set; }
        [StringLength(15)]
        public string? Phone { get; set; }

        [ForeignKey("Department")]
        public int? DeptID { get; set; }
        public virtual Department? Department { get; set; }

    }
}
