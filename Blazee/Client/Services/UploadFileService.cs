namespace Blazee.Client.Services
{
    public class UploadFileService
    {
        private readonly HttpClient client;

        public UploadFileService(HttpClient client)
        {
            this.client = client;
        }

        //public async Task<bool> UploadAsync(HttpContent? content)
        //{
        //   var response = await this.client.PostAsync("Image", content);

        //    if (response.IsSuccessStatusCode)
        //    {

        //        return true;
        //    }
        //}
    }
}
