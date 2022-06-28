using Microsoft.AspNetCore.Mvc;
using WebApplication1.abstraction;
using WebApplication1.Model;

namespace WebApplication1.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentHelper _helper;

    public StudentController(IStudentHelper studentHelper)
    {
        _helper = studentHelper;
    }


    public List<Student> students = new List<Student>()
    {
        new Student(1, "youssef", "youssef12@gmail.com"),new Student(2, "haddad", "youssef12@gmail.com")
    };

    [HttpGet]
    public List<Student>  Getstudents()
    {
        return students;
    }
    [HttpPost(Name = "Post0")]
    public IEnumerable<Student> Postudents([FromBody] Student s)
    {
        students.Add(s);
        return Getstudents();
    }

    [HttpGet("{id:long}")]
    public Student Getstudents1([FromRoute]long id)
    {
        return _helper.GetStudentsId(students,id);

    }
    
    [HttpGet("name/{name}")]
    public Student Getstudents_name([FromQuery]string name)
    {
        return _helper.GetStudentsName(students,name);

    }
    
    [HttpGet("{lang}")]
    public string GetDate([FromRoute]string lang)
    {
        return _helper.GetCurrentDate(lang);

    }
    [HttpPost("name/{name},id/{id}")]
    public List<Student> UpdateStudentName([FromBody] long id,string name)
    {
        _helper.ChangeUserName(id,name,students);
        return students;
    }
    
    
}