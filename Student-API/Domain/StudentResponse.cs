using Student_API.Models;

namespace Student_API.Domain
{
    public class StudentResponse
    {
        public List<Student> Data { get; }
        public string? Error { get; init; }
        public StudentResponse(List<Student> data= null, string? error = null)
        {
            Data = data;
            Error = error;
        }

    }
}
