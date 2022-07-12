using Microsoft.AspNetCore.Mvc;
using Moq;
using Student_API.Controllers;
using Student_API.Domain;
using Student_API.Models;
using Student_API.Services.Interface;

namespace UnitTests.Controllers;

public class StudentControllerTest
{
    [Fact]
    public void ShouldReturn200OnSuccess()
    {
        var mockStudentService = new Mock<IStudentService>();
        mockStudentService.Setup(service => service.GetAllStudents()).Returns(new List<Student>());
        var sut = new StudentController(mockStudentService.Object);

        var result = sut.GetAll();
        var res = (OkObjectResult)result.Result;
        var objRes = (StudentResponse)res.Value;

        Assert.Equal(200, res.StatusCode);
        Assert.Null(objRes.Error);
        Assert.NotNull(objRes.Data);

        mockStudentService.Verify(service => service.GetAllStudents(), Times.Once);
    }



    [Fact]
    public void ShouldReturn404NotFoundWhenExceptionOccurred()
    {
        var mockStudentService = new Mock<IStudentService>();
        mockStudentService.Setup(service => service.GetAllStudents()).Throws(new Exception("Server Error"));
        var sut = new StudentController(mockStudentService.Object);

        var result = sut.GetAll();
        var res = (NotFoundObjectResult)result.Result;
        var objRes = (StudentResponse)res.Value;

        Assert.Equal(404, res.StatusCode);
        Assert.Equal("Server Error", objRes.Error);
        Assert.Null(objRes.Data);

        mockStudentService.Verify(service => service.GetAllStudents(), Times.Once);
    }
}