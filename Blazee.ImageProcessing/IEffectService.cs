namespace Blazee.ImageProcessing
{
    public interface IEffectService
    {
        public Task<string> ApplyEfect(byte[] byteImage);
    }
}
