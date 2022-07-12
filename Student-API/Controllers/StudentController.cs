using Microsoft.AspNetCore.Mvc;
using Student_API.Domain;
using Student_API.Services.Interface;

namespace Student_API.Controllers
{
    [ApiController]
    [Route("api/")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("getAll")]
        public ActionResult<StudentResponse>? GetAll()
        {
            try
            {
                return Ok(new StudentResponse(_studentService.GetAllStudents()));
            }
            catch (Exception ex)
            {
                return NotFound(new StudentResponse(error: ex.Message));
            }
        }
    }
}