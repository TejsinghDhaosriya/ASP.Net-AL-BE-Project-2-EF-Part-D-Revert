using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_API.Models
{
    [Table("students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        public string name { get; set; }

        public string className { get; set; }

        public string rollNumber { get; set; }

        public int year_of_enrollment { get; set; }

    }
}
