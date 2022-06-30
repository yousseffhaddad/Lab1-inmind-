using System.Globalization;
using WebApplication1.abstraction;
using WebApplication1.Exceptions;
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
    
    public List<Student> ChangeUserName(long id,string name,List<Student> students)
    {
        bool flag = false;
        foreach (Student student in students)
        {
            if (student.id == id)
            {
                flag = true;
                student.name = name;
            }
        }
        if (!flag)
        {
            throw new StudentNotFoundException("student not found");
        }
        return students;
        
    }

    public List<Student> DeleteUser(long id, List<Student> students)
    {

        var studentToRemove = students.SingleOrDefault(r => r.id == id);
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            return students;
        }

        throw new StudentNotFoundException("Student not Found");
    }

}