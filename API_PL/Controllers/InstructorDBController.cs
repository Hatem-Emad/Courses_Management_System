using APIDay02_BL.DTO;
using APIDay02_BL.Manage;
using APIDay02_DAL.Data.Models;
using APIDay02_DAL.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDay02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorDBController : ControllerBase
    {
        //dh mosh task kont bgrb
        //This Controller gets FULL Instructor not InstructorDTO
        //It connects directly to Data Access Layer
        public IRepo<Instructor> Repo { get; }
        public InstructorDBController(IRepo<Instructor> repo)
        {
            Repo = repo;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<Instructor> instructors = Repo.GetAll();
            if (instructors.Count > 0)
                return Ok(instructors);
            return BadRequest();

        }
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            Instructor instructor = Repo.Get(id);
            if (instructor != null)
                return Ok(instructor);
            return BadRequest();
        }

        [HttpPost]
        public ActionResult Create(Instructor instructor)
        {
            Repo.Insert(instructor);
            return Ok(instructor);
        }

        [HttpPut]
        public ActionResult Edit(Instructor instructor)
        {

            Repo.Update(instructor);
            return Ok(instructor);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Instructor instructor = Repo.Get(id);
            Repo.Delete(id);
            return Ok(instructor);
        }


    }
}
