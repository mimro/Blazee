using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace Blazee.ImageProcessing
{
    public class EffectService : IEffectService
    {
        public async Task<string> ApplyEfect(byte[] byteImage) 
        {
             
            using (var img = Image.Load(byteImage))
            {
               return await Task.Run(() =>
                {
                    img.Mutate(m => m.OilPaint());
                    return img.ToBase64String(PngFormat.Instance);
                }
                );
            };
            
        }
    }
}