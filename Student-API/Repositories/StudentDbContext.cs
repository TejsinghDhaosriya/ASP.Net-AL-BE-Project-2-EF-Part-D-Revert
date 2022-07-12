using Microsoft.EntityFrameworkCore;

namespace Student_API.Repositories
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
    }
}
