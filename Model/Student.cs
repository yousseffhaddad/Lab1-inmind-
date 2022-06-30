using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model;

public class Student 
{
    [Required(ErrorMessage = "Please enter you id ")]
    public long id { get; set; }
    
    [Required]
    [MinLength(4, ErrorMessage= "Please enter at least 4 characters" )]
    public string name { get; set; }
    
    [Required]
    [EmailAddress(ErrorMessage= "Please enter a valid email address")]
    public string email { get; set; }
    
    public  Student(long id, String name, String email)
    {
        this.id = id;
        this.name = name;
        this.email = email;
    }
}