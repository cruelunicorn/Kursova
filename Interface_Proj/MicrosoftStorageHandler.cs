using Azure.Storage;
using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Proj
{
    /// <summary>
    /// Allows you to work with remote storage, download and upload files
    /// </summary>
    internal class MicrosoftStorageHandler
    {
        private readonly string accountName = "";
        private readonly string accessKey = "";
        private readonly string documentFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private readonly BlobServiceClient client;
        private readonly BlobContainerClient container;

        public MicrosoftStorageHandler()
        {
            var credentials = new StorageSharedKeyCredential(accountName, accessKey);
            var blobUri = $"https://{accountName}.blob.core.windows.net";
            client = new BlobServiceClient(new Uri(blobUri), credentials);
            this.container = client.GetBlobContainerClient("files");
            if (!Directory.Exists(Path.Combine(documentFolderPath, "StorageFiles")))
                Directory.CreateDirectory(Path.Combine(documentFolderPath, "StorageFiles"));
            documentFolderPath = Path.Combine(documentFolderPath, "StorageFiles");

        }

        /// <summary>Downloads file to C:/Users/User/Documents/StorageFiles </summary>
        /// <returns>Returns status string</returns>
        public async Task<string> DownloadFile(string downloadFileName, string folderName = "students")
        {
            if (!IsInternetAvailable()) return "No internet access";
            BlobClient blob = this.container.GetBlobClient($"{folderName}/{downloadFileName}");
            if (!await blob.ExistsAsync()) { return "File or folder doesn't exist"; }
            await blob.DownloadToAsync(Path.Combine(documentFolderPath, downloadFileName));
            return "Downloaded successfully";
        }

        /// <summary>Uploads file to remoted storage </summary>
        /// <returns>Returns status string</returns>
        public async Task<string> UploadFile(string uploadFileName, string folderName = "students")
        {
            if (!IsInternetAvailable()) return "No internet access";
            if (!File.Exists(uploadFileName)) { return "File doesn't exist"; }
            BlobClient blob = this.container.GetBlobClient($"{folderName}/{uploadFileName}");
            await blob.UploadAsync(uploadFileName, true);
            return "Uploaded successfully";
        }
        private static bool IsInternetAvailable()
        {
            using Ping ping = new();
            try
            {
                PingReply reply = ping.Send("www.google.com");
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}