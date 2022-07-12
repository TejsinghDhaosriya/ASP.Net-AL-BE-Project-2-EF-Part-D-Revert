using Student_API.Models;

namespace Student_API.Services.Interface
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
    }
}
