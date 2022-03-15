using Blazee.ImageProcessing;
using Blazee.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blazee.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IEffectService _effectService;

        public ImageController(IEffectService effectService)
        {
            _effectService = effectService;
        }

        [HttpPost]
        public async Task<string> Post([FromBody]string imageSerialized)
        {
            var imageModel = JsonConvert.DeserializeObject<ImageModel>(imageSerialized);
            
            byte[] imageBytes = Convert.FromBase64String(imageModel.ImageBase64String);

            var imageurl = await _effectService.ApplyEfect(imageBytes);
            
            return JsonConvert.SerializeObject(new ImageModel() { Source = imageurl});
        }
    }
}
