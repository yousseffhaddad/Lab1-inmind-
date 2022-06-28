using System.Globalization;
using WebApplication1.abstraction;
using WebApplication1.Model;

namespace WebApplication1.Service;

public class StudentHelper1 : IStudentHelper   
{
    public Student GetStudentsId(List<Student> students, long id)
    {
        return students.Where(x => x.id == id).First();
    }
    public Student GetStudentsName(List<Student> students, string name)
    {
        return students.Where(x => x.name == name).First();
    }

    public string GetCurrentDate(string language)
    {
        return DateTime.Now.Date.ToString("MM/dd/yyyy h:mm tt", new CultureInfo(language));

    }
}