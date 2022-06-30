using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model;

public class Student 
{
    [Required(ErrorMessage = "Please enter you id ")]
    public long id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    
    public string lastname { get; set; }


    public  Student(long id, String name, String email)
    {
        this.id = id;
        this.name = name;
        this.email = email;
    }
}