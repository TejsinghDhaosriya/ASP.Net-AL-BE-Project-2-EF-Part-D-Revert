using Microsoft.EntityFrameworkCore;
using Student_API.Models;

namespace Student_API.Repositories
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
