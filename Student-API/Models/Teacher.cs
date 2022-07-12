using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_API.Models
{
    [Table("teacher")]
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        public string name { get; set; }

        public string className { get; set; }

        public string rollNumber { get; set; }
    }
}
