using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIDay02_BL.DTO;
using APIDay02_DAL.Data.Models;
using APIDay02_DAL.Repo;

namespace APIDay02_BL.Manage
{
    public class InstructorRepoBL : IRepoBL<InstructorDTO>
    {
        public IRepo<Instructor> Repo { get; }

        public InstructorRepoBL(IRepo<Instructor> repo)
        {
            Repo = repo;
        }
        public List<InstructorDTO> GetAll()
        {
            var InstructorsFromRepo = Repo.GetAll();
            List<InstructorDTO> InstructorDTOs = new List<InstructorDTO>();
            foreach (var instructor in InstructorsFromRepo)
            {
                InstructorDTO ins = new InstructorDTO()
                {
                    Id = instructor.Id,
                    Name = instructor.Name,
                    Salary = instructor.Salary,
                    Age = instructor.Age,
                };
                InstructorDTOs.Add(ins);
            }
            return InstructorDTOs;
        }

        public InstructorDTO Get(int id)
        {
            InstructorDTO Ins = new();
            var insfromDB = Repo.Get(id);
            if (insfromDB != null)
            {
                Ins.Id = insfromDB.Id;
                Ins.Name = insfromDB.Name;
                Ins.Age = insfromDB.Age;
                Ins.Salary = insfromDB.Salary;
            }

            return Ins;
        }


        public void Insert(InstructorDTO item)
        {
            Instructor instructor = new Instructor()
            {
                Name = item.Name,
                Age = item.Age,
                Salary = item.Salary
            };
            Repo.Insert(instructor);
        }

        public void Update(InstructorDTO item)
        {
            Instructor instructor = new Instructor()
            {
                Name = item.Name,
                Age = item.Age,
                Salary = item.Salary
            };
            Repo.Update(instructor);
        }
        public void Delete(int id)
        {
            Repo.Delete(id);
        }
    }
}
