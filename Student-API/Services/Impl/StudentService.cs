using Student_API.Models;
using Student_API.Repositories.Interface;
using Student_API.Services.Interface;

namespace Student_API.Services.Impl
{
    public class StudentService:IStudentService
    {

        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
          return  _studentRepository.findAll();
        }
    }
}
