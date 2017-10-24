using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using Microsoft.WindowsAzure.Storage;

namespace MeetupDISample.BlobStorage
{
    public class AzureFileUpload
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        public AzureFileUpload()
        {
            _connectionString = "DefaultEndpointsProtocol=https;AccountName=ozgurblob;AccountKey=MDJowe/lI0VzKkDnrUh5sOBNNZjvTA5KA82Lb2vOC/hplfae/spIQWjkagdwhwD4NcYqgXw8SlfSs+WSh4qMyw==;EndpointSuffix=core.windows.net";
            _containerName = "file";
        }

        public void Upload(string fileName, string text)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(_connectionString);

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve reference to a previously created container.
            CloudBlobContainer container = blobClient.GetContainerReference(_containerName);
            // Retrieve reference to a blob named "myblob".
            CloudBlockBlob blockBlob = container.GetBlockBlobReference($"file/{fileName}.txt");
            using (MemoryStream stream = new MemoryStream())
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(text);
                writer.Flush();
                stream.Position = 0;
                blockBlob.UploadFromStreamAsync(stream).Wait();
            }
        }
    }
}