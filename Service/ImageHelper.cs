using WebApplication1.abstraction;

namespace WebApplication1.Service;

public class ImageHelper:IImageHelper 
{
    public string UploadImage(IFormFile file)
    {
        try
        {
            // getting file original name
            string FileName = file.FileName;
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