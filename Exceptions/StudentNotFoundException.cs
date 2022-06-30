using System.Runtime.Serialization;

namespace WebApplication1.Exceptions;

public class StudentNotFoundException:Exception
{
    public StudentNotFoundException()
    {
    }
    
    public StudentNotFoundException(string? message) : base(message)
    {
    }
    
}