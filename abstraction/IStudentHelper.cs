using WebApplication1.Model;

namespace WebApplication1.abstraction;

public interface IStudentHelper
{
    public Student GetStudentsId(List<Student> students, long id);
    public Student GetStudentsName(List<Student> students, string name);
    
    public string GetCurrentDate(string language);
    public List<Student>  ChangeUserName(long id,string name,List<Student> students);
    public List<Student>  DeleteUser(long id,List<Student> students);
    
    
}