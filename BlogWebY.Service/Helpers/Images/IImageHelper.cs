using BlogWebY.Entity.DTOs.Images;
using BlogWebY.Entity.Enums;
using Microsoft.AspNetCore.Http;

namespace BlogWebY.Service.Helpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUploadedDto> Upload(string name,IFormFile imageFile,ImageType imageType, string folderName=null);

         void Delete(string imageName);
    }
}
