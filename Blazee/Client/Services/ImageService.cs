using Blazee.Shared.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace Blazee.Client.Services
{
    public class ImageService
    {
        public byte[]? Bytes { get; set; }

        public string? Type { get; set; }

        //public string Base64Image => Convert.ToBase64String(Bytes);
        //public string Source => $"data:{Type};base64,{Base64Image}";

        public async Task PrepareImageFromFile(IBrowserFile? file, string ImageOutputType = "image/png")
        {
           // var img = await file.RequestImageFileAsync("image/png", 600, 600);
            if (file == null)
            {
                throw new ArgumentNullException();
            }
            
            var buffer = new byte[file.Size];
             await file.OpenReadStream().ReadAsync(buffer);


            Bytes = buffer;
            Type = ImageOutputType ;
        }


        public async Task<ImageModel> ResizeImage(int ImageHeight, int ImageWidth)
        {
            return null;
        }
    }
}
