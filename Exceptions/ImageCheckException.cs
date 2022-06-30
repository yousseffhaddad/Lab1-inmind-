namespace WebApplication1.Exceptions;

public class ImageCheckException:Exception
{
    public ImageCheckException()
    {
    }

    public ImageCheckException(string? message) : base(message)
    {
    }
}