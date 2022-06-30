using Microsoft.AspNetCore.Mvc;
using WebApplication1.abstraction;

namespace WebApplication1.Controllers;
[ApiController]
[Route("[controller]")]

public class ImageController:ControllerBase
{
    private readonly IImageHelper _helper; 

    public ImageController(IImageHelper imageHelper)
    {
        _helper = imageHelper;
    }
    
    [HttpPost]
    public string UploadImage([FromForm] IFormFile file )
    {
        return _helper.UploadImage(file);
        
    }
    
    
}