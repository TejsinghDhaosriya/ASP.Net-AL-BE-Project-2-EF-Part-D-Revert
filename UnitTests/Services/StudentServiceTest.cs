
using Moq;
using Student_API.Models;
using Student_API.Repositories.Interface;
using Student_API.Services.Impl;

namespace UnitTests.Services
{
    public class StudentServiceTest
    {
        [Fact]
        public void ShouldReturnStudentsData()
        {
            var data = new List<Student> { new(){id=1,name="example",className="12",rollNumber = "1313"} };
            var mockStudentRepository = new Mock<IStudentRepository>();
            mockStudentRepository.Setup(service => service.findAll()).Returns(data);

            var sut = new StudentService( mockStudentRepository.Object);
            var res = sut.GetAllStudents();
            
            Assert.Equal(data, res);


            mockStudentRepository.Verify(
                service => service.findAll(), Times.Once);
        }
    }
}
