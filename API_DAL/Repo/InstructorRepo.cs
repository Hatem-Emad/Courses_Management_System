using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDay02_DAL.Data.Context;
using APIDay02_DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDay02_DAL.Repo
{
    public class InstructorRepo : IRepo<Instructor>
    {
        public MainContext Context { get; }

        public InstructorRepo(MainContext context)
        {
            Context = context;
        }
        public List<Instructor> GetAll()
        {
            return Context.Instructors.Include(d => d.Department).ToList();
        }

        public Instructor Get(int id)
        {
            return Context.Instructors.Include(d => d.Department).SingleOrDefault(e => e.Id == id);
        }
        public void Insert(Instructor item)
        {
            Context.Instructors.Add(item);
            Context.SaveChanges();
        }

        public void Update(Instructor item)
        {
            Context.Instructors.Update(item);
            Context.SaveChanges();

        }
        public void Delete(int id)
        {
            Context.Instructors.Remove(Context.Instructors.FirstOrDefault(i => i.Id == id));
            Context.SaveChanges();

        }
    }
}
