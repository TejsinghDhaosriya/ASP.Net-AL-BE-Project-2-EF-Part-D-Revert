using Student_API.Models;
using Student_API.Repositories.Interface;

namespace Student_API.Repositories.Impl
{
    public class StudentRepository:IStudentRepository
    {
        private readonly StudentDbContext _studentDbContext;

        public StudentRepository(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        public List<Student> findAll()
        {
            var students = _studentDbContext.Students.ToList();
            return students;
        }
    }
}
