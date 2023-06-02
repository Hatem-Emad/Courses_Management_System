using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDay02_DAL.Data.Context;
using APIDay02_DAL.Data.Models;

namespace APIDay02_DAL.Repo
{
    public class DepRepo : IRepo<Department>
    {
        public MainContext Context { get; }

        public DepRepo(MainContext context)
        {
            Context = context;
        }
        public List<Department> GetAll()
            => Context.Departments.ToList();


        public Department Get(int id)
            => Context.Departments.SingleOrDefault(d => d.Id == id);


        public void Insert(Department item)
        {
            Context.Departments.Add(item);
        }

        public void Update(Department item)
        {
            Context.Departments.Update(item);
        }
        public void Delete(int id)
        {
            Context.Departments.Remove(Context.Departments.FirstOrDefault(i => i.Id == id));
        }
    }
}
