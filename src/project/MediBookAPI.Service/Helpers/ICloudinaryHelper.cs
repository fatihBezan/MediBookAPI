
using Microsoft.AspNetCore.Http;

namespace MediBookAPI.Service.Helpers;

public interface ICloudinaryHelper
{
   string UploadImage(IFormFile formFile, string imageDoctor);
}
