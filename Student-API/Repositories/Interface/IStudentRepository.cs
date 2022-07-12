using Student_API.Models;

namespace Student_API.Repositories.Interface
{
    public interface IStudentRepository
    {
        List<Student> findAll();
    }
}
