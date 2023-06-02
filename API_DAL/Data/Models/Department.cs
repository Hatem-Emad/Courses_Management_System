using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIDay02_DAL.Data.Models
{
    public class Department
    {
        [Key] public int Id { get; set; }
        [Required] public required string Name { get; set; }
        [StringLength(50)]
        public string? Location { get; set; }
        public int? Branches { get; set; }
        public string? Desc { get; set; }
        [JsonIgnore]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
