namespace Blazee.MatLab
{
    public class ImageToBinary
    {
        public object Process(byte[] Image)
        {
            byte[] image = System.IO.File.ReadAllBytes(@"C:\Users\Dell\source\repos\matlabLibTest\matlabLibTest\inz.jpg");
            var imgToProcess = new imageToBinaryNative.MLImageProcessingService();
            var processedImage = imgToProcess.imageToBinary(image, 0.5);
            return processedImage;
        }
    }
}