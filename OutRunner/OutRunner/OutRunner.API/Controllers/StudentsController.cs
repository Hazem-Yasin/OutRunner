using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OutRunner.API.Controllers
{
    //https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET:https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "John", "Jane", "ds;lajlkdasj;lkd", "Emily", "David"};
            string[] TeacherNames = new string[] { "Dr.Hazem", "Mr.jaslkd", "Prof.asdlksaj" };

            return Ok();
        }

    }
}
