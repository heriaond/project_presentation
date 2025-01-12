using Infrastructure.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers;

[ApiController]
[Route("api/weather")]
public class StudentController : ControllerBase
{
    private readonly IStudentService studentService;
    public StudentController(IStudentService studentService)
    {
        this.studentService = studentService;
    }
    
    [HttpGet("getNumber")]
    public int GetNumber()
    {
        return studentService.SumTwoNumbers(1,2);
    }
    
    [HttpPost("getNumberSum")]
    public int GetNumberSum([FromBody] RequestNumbers requestNumbers)
    {
        var a = requestNumbers.Anum;
        var b = requestNumbers.Bnum;
        return studentService.SumTwoNumbers(a,b);
    }
}


















