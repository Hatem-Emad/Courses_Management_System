using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDay02_DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDay02_DAL.Data.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options) { } 

        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
       
    }
}
