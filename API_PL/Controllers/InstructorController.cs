using APIDay02_BL.DTO;
using APIDay02_BL.Manage;
using APIDay02_DAL.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDay02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {

        //public InstructorRepoBL Instructor { get; }

        //public InstructorController(InstructorRepoBL instructor)
        //{
        //    Instructor = instructor;
        //}

        //Inject Interface not Class https://stackoverflow.com/questions/10311571/dependency-injection-with-interfaces-or-classes

        public IRepoBL<InstructorDTO> RepoBL { get; }
        public InstructorController(IRepoBL<InstructorDTO> repo)
        {
            RepoBL = repo;
        }
        [HttpGet]
        public ActionResult Index()
        {
            List<InstructorDTO> instructorDTOs = RepoBL.GetAll();
            if(instructorDTOs.Count > 0)
                return Ok(instructorDTOs);
            return BadRequest();

        }
        //[HttpGet]     KOOOOOL DH 3SHAN NSEET EL {("{id}")     !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //THE APPLICATION DIDNOT RUN
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //in the console error:
        // Conflicting method/path combination "GET api/Instructor" for actions
        // - APIDay02.Controllers.InstructorController.Index (APIDay02),
        // APIDay02.Controllers.InstructorController.Details (APIDay02).
        // Actions require a unique method/path combination

        //in browser error:
        //Failed to load API definition.

        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            InstructorDTO instructorDTO = RepoBL.Get(id);
            if(instructorDTO != null)
                return Ok(instructorDTO);
            return BadRequest();
        }

        [HttpPost]
        public ActionResult Create( InstructorDTO instructorDTO)
        {
            RepoBL.Insert(instructorDTO);
            return Ok(instructorDTO);
        }

        [HttpPut]
        public ActionResult Edit(InstructorDTO instructor)
        {

            RepoBL.Update(instructor);
            return Ok(instructor);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            InstructorDTO instructor = RepoBL.Get(id);
            RepoBL.Delete(id);
            return Ok(instructor);
        }

        
    }
}
