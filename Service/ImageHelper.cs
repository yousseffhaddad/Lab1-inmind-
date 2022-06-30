using WebApplication1.abstraction;
using WebApplication1.Exceptions;

namespace WebApplication1.Service;

public class ImageHelper:IImageHelper 
{
    public string UploadImage(IFormFile file)
    {  
        List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" }; 
        bool flag = false;
        
        try
        {
            // getting file original name
            string FileName = file.FileName;
            foreach (var x in ImageExtensions)
            {  
                if (FileName.Contains(x))
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                throw new ImageCheckException("Error the file is not an image");
            }
            // combining GUID to create unique name before saving in wwwroot
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + FileName;
            // getting full path inside wwwroot/images
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", FileName);
        
            // copying file
            file.CopyTo(new FileStream(imagePath, FileMode.Create));
            return "File Uploaded Successfully";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}