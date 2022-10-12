using Azure.Storage.Blobs;

namespace SuaTeoriaWebAssembly.Pages.Adm
{
    public static class FileUpload
    {
        public static string UploadBase64Image(string base64Image, string container)
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=suateoria;AccountKey=CuZyhXE1qt56tx1b5MlvzlLpklEDKohMZvIDPmmrR8ATMJJ59sr8iY8eGYI8OZNnlqmXEkPwf7yA+ASta7Y7/w==;EndpointSuffix=core.windows.net";
            var fileName = Guid.NewGuid().ToString() + ".jpg";
            byte[] imageBytes = Convert.FromBase64String(base64Image);
            var blobClient = new BlobClient(connectionString, container, fileName);
            using (var stream = new MemoryStream(imageBytes))
            {
                blobClient.Upload(stream);
            }

            return blobClient.Uri.AbsoluteUri;

        }
    }
}
